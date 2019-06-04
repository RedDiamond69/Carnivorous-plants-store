using Autofac;
using Autofac.Integration.Mvc;
using AutoMapper;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.AspNet.Identity.Owin;
using OnlineStore.DataProvider;
using OnlineStore.DataProvider.Interfaces;
using OnlineStore.Logic.Interfaces;
using OnlineStore.Logic.Services;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

[assembly: OwinStartup(typeof(OnlineStore.Website.App_Start.AutofacConfig))]
namespace OnlineStore.Website.App_Start
{
    public partial class AutofacConfig
    {
        public void Configuration(IAppBuilder app)
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();

            builder.RegisterAssemblyTypes(Assembly.Load("OnlineStore.Logic"))
                .Where(t => t.Name.EndsWith("Service"))
                .AsImplementedInterfaces().InstancePerRequest();
            builder.Register(c => HttpContext.Current.GetOwinContext().Authentication).InstancePerRequest();
            builder.RegisterModule(new AutoMapperModule());

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            app.UseAutofacMiddleware(container);
            app.UseAutofacMvc();

            ConfigurationAuth(app);
        }
    }
}