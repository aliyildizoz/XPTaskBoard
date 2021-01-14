using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public class XPTaskBoardDBInitializer : CreateDatabaseIfNotExists<XPTaskBoardDbContext>
    {
        protected override void Seed(XPTaskBoardDbContext context)
        {
            List<TaskState> taskStates = new List<TaskState>();
            taskStates.Add(new TaskState() { Name = nameof(TaskStateNames.Delete) });
            taskStates.Add(new TaskState() { Name = nameof(TaskStateNames.Update) });
            taskStates.Add(new TaskState() { Name = nameof(TaskStateNames.Create) });
            taskStates.Add(new TaskState() { Name = nameof(TaskStateNames.ToDo) });
            taskStates.Add(new TaskState() { Name = nameof(TaskStateNames.Doing) });
            taskStates.Add(new TaskState() { Name = nameof(TaskStateNames.Done) });
            taskStates.Add(new TaskState() { Name = nameof(TaskStateNames.AddEmployee) });
            taskStates.Add(new TaskState() { Name = nameof(TaskStateNames.RemoveEmployee) });
            context.TaskStates.AddRange(taskStates);
            context.Projects.Add(new Project(){Name = "Kütüphane takip sistemi."});
            context.Projects.Add(new Project() {Name = "Sipariş yönetimi sistemi."});
            base.Seed(context);
        }
    }
}
