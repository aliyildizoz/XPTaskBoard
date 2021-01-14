using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Results;
using Entities;
using Task = Entities.Task;

namespace Business.Abstract
{
    public interface ITaskService
    {
        IDataResult<List<Task>> GetAllList();
        IDataResult<List<Task>> GetDoingList(int projectId);
        IDataResult<List<TaskTrack>> GetTracks(int projectId);
        IDataResult<List<Task>> GetDoneList(int projectId);
        IDataResult<List<Task>> GetToDoList(int projectId);
        IDataResult<Task> GetByIdWithTaskTracks(int id);
        IDataResult<Task> GetById(int id);
        IDataResult<Task> Add(Task task);
        IResult Delete(int id);
        IResult Update(Task task);
        IResult AddEmployee(Task task, Employee employee);
        IResult RemoveEmployee(Task task, Employee employee);
        IResult UpdateState(int argsTaskId, TaskStateBaseNames selected);
    }
}
