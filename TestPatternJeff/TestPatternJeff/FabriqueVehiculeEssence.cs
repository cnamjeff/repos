using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPatternJeff
{
    public class FabriqueVehiculeEssence : FabriqueVehicule
    {
        public new AutomobileEssence AutomobileEssence(string marque, string couleur, string type, int puissance)
        {
             return new AutomobileEssence(marque,couleur,type,puissance);
        }

        public new ScooterEssence ScooterEssence(string modele, string couleur, string type, int puissance, double espace)
        {
             return new ScooterEssence(modele, couleur, type, puissance, espace);
        }
    }
}
