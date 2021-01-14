using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfTaskDal : EfEntityRepositoryBase<Task, XPTaskBoardDbContext>, ITaskDal
    {
        public void AddEmployee(Task task, Employee employee)
        {
            using (var context = new XPTaskBoardDbContext())
            {
                var result = context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, "insert into TaskEmployees (Task_Id,Employee_Id) values(@p0,@p1)", task.Id, employee.Id);
            }
        }

        public void RemoveEmployee(int taskId, Employee employee)
        {
            using (var context = new XPTaskBoardDbContext())
            {
                var result = context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, "Delete From TaskEmployees Where Task_Id=@p0 and Employee_Id=@p1", taskId, employee.Id);
            }
        }
    }
}
