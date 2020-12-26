using DeleteFacade;

namespace DeleteTheTest
{
    abstract class AFacade
    {
        public IMoto Moto { get; private set; }
        public IVehicule Vehicule { get; private set; }

        public AFacade(IMoto moto,IVehicule vehicule)
        {
            Moto = moto;
            Vehicule = vehicule;
        }

        public void FacadeCouleurMoto() { }
        public void FacadeCouleurVehicule() { }
    }
}