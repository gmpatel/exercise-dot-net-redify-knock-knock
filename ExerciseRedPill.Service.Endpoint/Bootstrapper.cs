using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Description;
using System.Web;
using System.Web.Routing;
using Autofac;
using Autofac.Integration.Wcf;
using ExerciseRedPill.Service.Business;
using knockknock.readify.net;

namespace ExerciseRedPill.Service.Endpoint
{
    public static class Bootstrapper
    {
        public static IContainer Container { get; private set; }

        static Bootstrapper()
        {
            ConfigureContainer();
        }

        public static IContainer ConfigureContainer()
        {
            var cb = new ContainerBuilder();

            cb.RegisterType<RedPill>().As<IRedPill>();
            cb.RegisterType<ShapeIdentifier>().As<IShapeIdentifier>();
            cb.RegisterType<StringOperator>().As<IStringOperator>();
            cb.RegisterType<FibonacciProvider>().As<IFibonacciProvider>();

            Container = cb.Build();

            return Container;
        }
    }
}