using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Autofac.Core;
using Business.Abstract;

namespace Business.DIResolvers
{
    public static class DI
    {
        public static IContainer Container { get; set; }
        private static ContainerBuilder builder;
        static DI()
        {
            builder = new ContainerBuilder();
            builder.RegisterModule<RegisterIoC>();
            Container = builder.Build();
        }

        public static T GetService<T>()
        {
            T service;
            using (var op = Container.BeginLifetimeScope())
            {
                service = op.Resolve<T>();
            }

            return service;
        }
    }
}
