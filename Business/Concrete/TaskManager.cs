using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Results;
using Business.Validation;
using DataAccess.Abstract;
using Entities;
using Task = Entities.Task;

namespace Business.Concrete
{
    public class TaskManager : ITaskService
    {
        private ITaskDal _taskDal;
        private Validation<TaskValidator> _validation;
        private ITaskTrackDal _taskTrackDal;
        public TaskManager(ITaskDal taskDal, ITaskTrackDal taskTrackDal)
        {
            _taskDal = taskDal;
            _taskTrackDal = taskTrackDal;
        }

        public IDataResult<List<Task>> GetAllList()
        {
            return new SuccessDataResult<List<Task>>(_taskDal.GetList().ToList());
        }

        public IDataResult<List<Task>> GetDoingList(int projectId)
        {
            return new SuccessDataResult<List<Task>>(_taskDal.GetListWithOneIncludes(task => task.TaskState, task => task.TaskState.Id == (int)TaskStateNames.Doing && task.ProjectId == projectId).OrderByDescending(task => task.Id).ToList());
        }

        public IDataResult<List<TaskTrack>> GetTracks(int projectId)
        {
            var result = _taskTrackDal.GetListWithTwoIncludes(track => track.TaskState, track => track.Task,
                track => track.Task.ProjectId == projectId);
            return new SuccessDataResult<List<TaskTrack>>(result.OrderByDescending(task => task.CreateDate).ToList());
        }

        public IDataResult<List<Task>> GetDoneList(int projectId)
        {
            return new SuccessDataResult<List<Task>>(_taskDal.GetListWithOneIncludes(task => task.TaskState, task => task.TaskState.Id == (int)TaskStateNames.Done && task.ProjectId == projectId).OrderByDescending(task => task.Id).ToList());
        }

        public IDataResult<List<Task>> GetToDoList(int projectId)
        {
            return new SuccessDataResult<List<Task>>(_taskDal.GetListWithOneIncludes(task => task.TaskState, task => task.TaskState.Id == (int)TaskStateNames.ToDo && task.ProjectId == projectId).OrderByDescending(task => task.Id).ToList());
        }

        public IDataResult<Task> GetByIdWithTaskTracks(int id)
        {
            var res = _taskDal.GetWithThreeIncludes(task => task.Id == id, task => task.TaskTracks,
                task => task.Employees, task => task.TaskState);
            foreach (var resTaskTrack in res.TaskTracks)
            {
                resTaskTrack.TaskState = _taskTrackDal
                    .GetWithOneIncludes(track => track.Id == resTaskTrack.Id, track => track.TaskState).TaskState;
            }
            return new SuccessDataResult<Task>(res);
        }
        public IDataResult<Task> GetById(int id)
        {
            var res = _taskDal.GetWithThreeIncludes(task => task.Id == id, task => task.TaskTracks,
                task => task.Employees, task => task.TaskState);
            return new SuccessDataResult<Task>(res);
        }
        public IDataResult<Task> Add(Task task)
        {
            _validation = new Validation<TaskValidator>();
            _validation.Validate(task);
            _taskDal.Add(task);
            return new SuccessDataResult<Task>(task);
        }

        public IResult Delete(int id)
        {
            _taskDal.Delete(new Task { Id = id });
            return new SuccessResult();
        }

        public IResult Update(Task task)
        {
            _validation = new Validation<TaskValidator>();
            _validation.Validate(task);
            _taskDal.Update(task);
            return new SuccessResult();
        }

        public IResult AddEmployee(Task task, Employee employee)
        {
            _taskDal.AddEmployee(task, employee);
            return new SuccessResult();
        }

        public IResult RemoveEmployee(Task task, Employee employee)
        {
            _taskDal.RemoveEmployee(task.Id, employee);
            return new SuccessResult();
        }

        public IResult UpdateState(int argsTaskId, TaskStateBaseNames selected)
        {
            var result = GetById(argsTaskId).Data;
            result.TaskStateId = (int)selected;
            result.TaskState = new TaskState() { Id = (int)selected };
            return Update(result);
        }
    }
}
