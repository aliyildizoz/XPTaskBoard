using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Results;
using DataAccess.Abstract;
using Entities;

namespace Business.Utilities
{
    public class BusinessHelper : IBusinessHelper
    {
        private ITaskDal _taskDal;
        private ITaskTrackDal _taskTrackDal;
        public BusinessHelper(ITaskDal taskDal, ITaskTrackDal taskTrackDal)
        {
            _taskDal = taskDal;
            _taskTrackDal = taskTrackDal;
        }

        public DateTime AvgTaskEstimated(int projectId)
        {
            Dictionary<int, int> days = new Dictionary<int, int>();

            var taskTracks = _taskTrackDal
                  .GetListWithTwoIncludes(track => track.TaskState, track => track.Task, track => track.EventDescription.ToLower().Contains(nameof(TaskStateBaseNames.ToDo).ToLower()) ||
                      track.EventDescription.ToLower().Contains(nameof(TaskStateBaseNames.Done).ToLower()) ||
                      track.EventDescription.ToLower().Contains(nameof(TaskStateBaseNames.Doing).ToLower()))
                  .OrderByDescending(track => track.CreateDate).ToList();


            if (taskTracks.Count > 0)
            {
                taskTracks.ForEach(track =>
                {

                    var firstTaskTracks = taskTracks.Where(taskTrack => taskTrack.Task.Id == track.Task.Id && taskTrack.Task.ProjectId == projectId).OrderByDescending(taskTrack => taskTrack.CreateDate).ToList();
                    if (firstTaskTracks.Count > 0)
                    {
                        var firstTaskTrack = firstTaskTracks.First();
                        if (firstTaskTrack.EventDescription.ToLower().Contains(nameof(TaskStateBaseNames.Done).ToLower()))
                        {
                            TimeSpan dayDiff = firstTaskTrack.CreateDate - firstTaskTrack.Task.CreateDate;
                            if (!days.ContainsKey(firstTaskTrack.Task.Id))
                            {
                                days.Add(firstTaskTrack.Task.Id, dayDiff.Days);
                            }

                        }
                    }
                });
            }

            DateTime estDateTime;
            if (days.Count == 0 || days.Sum(pair => pair.Value) == 0)
            {
                estDateTime = DateTime.Now.AddDays(10);
            }
            else
            {
                var avg2 = Math.Ceiling(days.Average(pair => pair.Value));
                estDateTime = DateTime.Now.AddDays(avg2);
            }

            return estDateTime;
        }

        public IDataResult<DateTime> DoneDate(int projectId, int taskId)
        {
            if (IsDone(projectId, taskId))
            {
                var taskTracks = _taskTrackDal
                    .GetListWithTwoIncludes(track => track.TaskState, track => track.Task, track => track.EventDescription.ToLower().Contains(nameof(TaskStateBaseNames.Done).ToLower()) && track.Task.ProjectId == projectId && track.Task.Id == taskId)
                    .OrderByDescending(track => track.CreateDate).ToList();
                if (taskTracks.Count > 0)
                {
                    var firstTaskTrack = taskTracks.First();
                    if (firstTaskTrack.EventDescription.ToLower().Contains(nameof(TaskStateBaseNames.Done).ToLower()))
                    {
                        return new SuccessDataResult<DateTime>(firstTaskTrack.CreateDate);
                    }
                }
            }

            return new ErrorDataResult<DateTime>(DateTime.Now);
        }

        private bool IsDone(int projectId, int taskId)
        {
            var task = _taskDal.Get(t => t.ProjectId == projectId && t.Id == taskId);
            return task.TaskStateId == (int)TaskStateBaseNames.Done;
        }
    }
}
