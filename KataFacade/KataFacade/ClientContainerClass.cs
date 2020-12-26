
using Couche2;
using Autofac;
using System;

namespace KataFacade
{
    class ClientContainerClass
    {
        private static IContainer Container { get; set; }

        public void ContainerTest()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<SubSytem1>().As<ISubSytem1>();
            builder.RegisterType<SubSystem2>().As<ISubSystem2>();
            builder.RegisterType<SubSystem3>().As<ISubSystem3>();        

            Container = builder.Build();
        }

    }
}
