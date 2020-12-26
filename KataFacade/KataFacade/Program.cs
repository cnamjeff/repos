using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Autofac.Core;
using Couche2;

namespace KataFacade
{
    sealed class Program
    {
        //private static SubSystem3 subSystem3;
        //private static SubSystem2 subSystem2;
        //private static SubSytem1 subSytem1;
        private static IContainer Container { get; set; }

        static void Main(string[] args)
        {
            WriteDate();
            //FacadeClass Facade = new FacadeClass(subSytem1, subSystem2, subSystem3);
            //Facade.MethodSubSystem1();
            //Facade.MethodSubSystem2();
            //Facade.MethodSubSystem3();
            Console.ReadLine();

        }

        public static void WriteDate()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<SubSytem1>().As<ISubSytem1>().SingleInstance();
            builder.RegisterType<SubSystem2>().As<ISubSystem2>();
            builder.RegisterType<SubSystem3>().As<ISubSystem3>();
            Container = builder.Build();
            InitialisationScope(Container);
           
        }

        public static void InitialisationScope(IContainer container)
        {
            using (var scope = Container.BeginLifetimeScope())
            {
                var writer1 = scope.Resolve<ISubSytem1>();
                var writer2 = scope.Resolve<ISubSystem2>();
                var writer3 = scope.Resolve<ISubSystem3>();
                AFacadeClass facade = new AFacadeClass(writer1, writer2, writer3);
                facade._SubSystem3.NameOfClass();
                writer1.NameOfClass();
                writer2.NameOfClass();
                writer2.subSystem3.NameOfClass();
                writer1.SubSystem2().subSystem3.NameOfClass();
                writer3.NameOfClass();
            }
          
        }
    }

   
}
