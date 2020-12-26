using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPatternJeff
{
    public class FabriqueVehiculeElectrique : FabriqueVehicule
    {
        public new AutomobileElectrique AutomobileElectrique(string marque, string couleur, string type, int puissance)
        {
            return new AutomobileElectrique(marque,couleur, type, puissance);
        }

        public new ScooterElectrique ScooterElectrique(string modele, string couleur, string type,int puissance, double espace)
        {
            return new ScooterElectrique(modele, couleur, type, puissance,espace );
        }
    }
}
