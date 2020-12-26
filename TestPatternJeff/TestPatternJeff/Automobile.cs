using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPatternJeff
{
    public abstract class Automobile : IVehicule
    {
        protected string marque;
        protected string couleur;
        protected string type;
        protected int puissance;

        public Automobile (string marque, string couleur, string type, int puissance)
        {
            this.marque = marque;
            this.couleur = couleur;
            this.type = type;
            this.puissance = puissance;
        }

        public abstract void afficheCaracteristique();
        
    }
}
