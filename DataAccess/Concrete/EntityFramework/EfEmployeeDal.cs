using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfEmployeeDal : EfEntityRepositoryBase<Employee, XPTaskBoardDbContext>, IEmployeeDal
    {
        public override void Delete(Employee entity)
        {
            using (var context = new XPTaskBoardDbContext())
            {
                var deleteEmp = context.Employees.FirstOrDefault(e => e.Id == entity.Id);
                if (deleteEmp != null)
                {
                    var name = deleteEmp.ToString().ToLower();
                    var deleteTaskTracks = context.TaskTracks.Where(track => track.EventDescription.ToLower().Contains(name)).ToList();
                    if (deleteTaskTracks.Count > 0)
                    {
                        context.TaskTracks.RemoveRange(deleteTaskTracks);
                        context.SaveChanges();
                    }
                }


            }
            base.Delete(entity);
        }
    }
}
