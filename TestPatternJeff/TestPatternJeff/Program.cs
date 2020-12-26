using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPatternJeff
{
    public class Program
    {
        static void Main(string[] args)
        {
          
            FabriqueVehicule FabriqueToyota = new FabriqueVehiculeElectrique();
            FabriqueToyota.AutomobileElectrique("Opel", "noir", "electrique", 150).afficheCaracteristique();
            
            Console.WriteLine("-----------------------------");
            FabriqueVehicule FabriqueYamaha = new FabriqueVehiculeEssence();
            FabriqueYamaha.ScooterEssence("yamaha", "rouge", "essence", 250, 0.2).afficheCaracteristique();
            Console.WriteLine(MinObjet.jfh.Color);
            Console.ReadLine();

           
        }
    }
}
