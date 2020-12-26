using DeleteFacade;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeleteTheTest
{
    class Facade : AFacade
    {
        public Facade(IMoto moto, IVehicule vehicule) : base(moto, vehicule)
        {
        }

        public new void FacadeCouleurMoto()
        {
            Moto.Couleur();
           
        }

        public new void FacadeCouleurVehicule()
        {
            Vehicule.Couleur();
        }
    }
}
