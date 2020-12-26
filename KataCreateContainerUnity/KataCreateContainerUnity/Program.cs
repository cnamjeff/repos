using System;
using Unity;
using Unity.Injection;

namespace KataCreateContainerUnity
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new Unity.UnityContainer();
            container.RegisterType<ICar, BMW>();
            container.RegisterType<ICar, Audi>("LuxuryCar");
            // Registers Driver type            
            container.RegisterType<Driver>("LuxuryCarDriver",
                            new InjectionConstructor(container.Resolve<ICar>("LuxuryCar")));

            Driver driver1 = container.Resolve<Driver>();// injects BMW
            driver1.RunCar();

            Driver driver2 = container.Resolve<Driver>("LuxuryCarDriver");// injects Audi
            driver2.RunCar();
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
