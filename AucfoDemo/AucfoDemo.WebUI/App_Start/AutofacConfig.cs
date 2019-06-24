using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using AutofacDemo.IBLL;
using AutofacDemo.BLL;

namespace AucfoDemo.WebUI.App_Start
{
    public class AutofacConfig
    {
        public static void Register()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<BooksCategoryManager>().As<IBooksCategoryManager>();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

        }
    }
}