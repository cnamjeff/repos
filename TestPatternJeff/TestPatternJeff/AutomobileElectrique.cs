using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPatternJeff
{
    public class AutomobileElectrique : Automobile
    {
        public AutomobileElectrique(string marque, string couleur, string type, int puissance) : base(marque, couleur, type, puissance)
        {
        }

        public override void afficheCaracteristique()
        {
            Console.WriteLine(marque);
            Console.WriteLine(couleur);
            Console.WriteLine(type);
            Console.WriteLine(puissance);
            
        }
    }
}
