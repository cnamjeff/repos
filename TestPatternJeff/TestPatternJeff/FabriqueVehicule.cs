using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPatternJeff
{
    public abstract class FabriqueVehicule 
    {
        public AutomobileElectrique AutomobileElectrique(string marque, string couleur, string type, int puissance)
        {
            return new AutomobileElectrique(marque, couleur, type, puissance);
        }
        public ScooterElectrique ScooterElectrique(string modele, string couleur, string type, int puissance, double espace)
        {
            return new ScooterElectrique(modele, couleur, type, puissance, espace);
        }

        public AutomobileEssence AutomobileEssence(string marque, string couleur, string type, int puissance)
        {
            return new AutomobileEssence(marque, couleur, type, puissance);
        }

        public ScooterEssence ScooterEssence(string modele, string couleur, string type, int puissance, double espace)
        {
            return new ScooterEssence(modele, couleur, type, puissance, espace);
        }

    }
}
