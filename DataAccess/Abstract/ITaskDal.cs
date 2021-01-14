using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Concrete;
using Entities;

namespace DataAccess.Abstract
{
    public interface ITaskDal : IEntityRepository<Task>
    {
        void AddEmployee(Task task, Employee employee);
        void RemoveEmployee(int taskId,Employee employee);
    }
}
