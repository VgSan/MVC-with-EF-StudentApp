using Autofac;
using Autofac.Integration.Mvc;
using BL.Interface;
using DL.IRepository;
using EF;
using EF.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMVC.Controllers;

namespace WebMVC.App_Start
{
    public class IoCConfig
    {
        public static IContainer RegisterDependencies()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            
            builder.RegisterAssemblyTypes(typeof(BL.Implementation.StudentService).Assembly).Where(t => t.Name.EndsWith("Service"))
                .AsImplementedInterfaces().InstancePerLifetimeScope();

            builder.RegisterType<SchoolContext>().InstancePerLifetimeScope();

            builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>));

            IContainer container = builder.Build();

            return container;
        }
    }
}