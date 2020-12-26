
using CouplageFort;
using CouplageFort.Interface;
using System;
using System.IO;
using Microsoft.Framework.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace CouplageFort
{
    class Program
    {
        static void Main(string[] args)
        {

            ServiceCollection service = new ServiceCollection();

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
