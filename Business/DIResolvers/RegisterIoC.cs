using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.EntityFramework.Context;

namespace Business.DIResolvers
{
    public class RegisterIoC : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EfTaskDal>().As<ITaskDal>();
            builder.RegisterType<EfTaskStateDal>().As<ITaskStateDal>();
            builder.RegisterType<EfTaskTrackDal>().As<ITaskTrackDal>();
            builder.RegisterType<EfEmployeeDal>().As<IEmployeeDal>();
            builder.RegisterType<EfProjectDal>().As<IProjectDal>();


            builder.RegisterType<EmployeeManager>().As<IEmployeeService>();
            builder.RegisterType<EmployeeManager>().As<IEmployeeService>();
            builder.RegisterType<TaskManager>().As<ITaskService>();
            builder.RegisterType<ProjectManager>().As<IProjectService>();
        }
    }
}
