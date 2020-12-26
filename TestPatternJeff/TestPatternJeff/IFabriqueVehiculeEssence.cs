using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPatternJeff
{
    public interface IFabriqueVehiculeEssence
    {
        AutomobileEssence AutomobileEssence(string marque, string couleur, string type, int puissance);
        ScooterEssence ScooterEssence(string modele, string couleur, string type, int puissance, double espace);
    }
}
