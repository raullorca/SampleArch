using Autofac;
using SampleArch.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleArch.Modules
{
    public class EFModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
                .RegisterType(typeof(SampleArchContext))
                .As(typeof(IContext))
                .InstancePerLifetimeScope();
        }
    }
}