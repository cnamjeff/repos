using DeleteFacade;
using System;

namespace DeleteTheTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IVehicule vehicule = new Vehicule();
            IMoto moto = new Moto();
            Facade facade = new Facade(moto,vehicule);
            facade.FacadeCouleurMoto();
            facade.FacadeCouleurVehicule();
            Console.ReadLine();
        }
    }
}
