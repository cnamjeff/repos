using Microsoft.Extensions.DependencyInjection;
using System;

namespace IocCore
{
    class Program
    {
        static void Main(string[] args)
        {

            public void ConfigureServices(IServiceCollection services)
            {
                services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

                //we added this code
                ConfigureDependencies(services);
            }

            private void ConfigureDependencies(IServiceCollection services)
            {
                //get from configuration file 
                var isSimulation = true;

                //Register services into the container 
                services.AddSingleton<IDAOImpl, DAOImpl>();
                services.AddTransient<IRepository>(provider => new Repository(provider.GetService<IDAOImpl>(), isSimulation));
            }
            ServiceCollection service = new ServiceCollection();
            /*
            var path = "C:\\Users\\mercu\\source\\repos\\Couplage Fort\\Couplage Fort\\Config.txt";
            string[] data = File.ReadAllLines(path);
            string DaoClassName = data[0];
            string MetierImpl = data[1];

            Type TypeDao = Type.GetType(DaoClassName);
            IDAOImpl dao = (IDAOImpl)Activator.CreateInstance(TypeDao);
            Type TypeMetier = Type.GetType(MetierImpl);
            IMetierImpl metier = (IMetierImpl)Activator.CreateInstance(TypeMetier, dao);
            Console.WriteLine("resultat est :" + metier.Calcul());
            Console.ReadLine();
            */

            /*
            DAOImpl DAO = new DAOImpl();
            IMetierImpl Temperature = new MetierImpl();
            Temperature.Dao = DAO;
            var temp = Temperature.Calcul();
            Console.WriteLine("la température et de : " + temp);
            Console.ReadLine();
            */
        }
    }
}
