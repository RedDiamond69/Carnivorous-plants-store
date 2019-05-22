using Autofac;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineStore.Website.App_Start
{
    public class AutoMapperModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddMaps(typeof(MvcApplication).Assembly);
            });

            builder.RegisterInstance(config).SingleInstance();
            builder.Register(c => c.Resolve<MapperConfiguration>().CreateMapper(c.Resolve))
                .As<IMapper>()
                .InstancePerRequest();
        }
    }
}