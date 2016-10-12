﻿using Autofac;
using Autofac.Integration.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using TCReport.Dal.Aspects.User;

namespace TCReport.App_Start
{
    public class IOCContainerConfig
    {
        public IDependencyResolver Config()
        {
            var builder = new ContainerBuilder();
            SetupResolveRules(builder);
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            var container = builder.Build();
            return new AutofacDependencyResolver(container);
        }
        private void SetupResolveRules(ContainerBuilder builder)
        {
            builder.RegisterType<AccountBaseAct>().As<IAccountBaseAct>(); 
        }
    }
}