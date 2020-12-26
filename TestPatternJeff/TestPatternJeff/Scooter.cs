using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPatternJeff
{
    public abstract class Scooter : IVehicule
    {
        protected string modele;
        protected string couleur;
        protected int puissance;
        protected string type;
        protected double espace;

        public Scooter(string modele, string couleur, string type, int puissance, double espace)
        {
            this.modele = modele;
            this.couleur = couleur;
            this.type = type;
            this.puissance = puissance;
            this.espace = espace;
        }

        public abstract void afficheCaracteristique();
      
    }
}


