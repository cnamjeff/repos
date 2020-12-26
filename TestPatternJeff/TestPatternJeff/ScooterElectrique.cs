using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPatternJeff
{
    public class ScooterElectrique : Scooter
    {
        public ScooterElectrique(string modele, string couleur, string type, int puissance, double espace) : base(modele, couleur, type, puissance, espace)
        {
        }

        public override void afficheCaracteristique()
        {
            Console.WriteLine(modele);
            Console.WriteLine(couleur);
            Console.WriteLine(type);
            Console.WriteLine(puissance);
            Console.WriteLine(espace);
            Console.ReadLine();
        }
    }
}