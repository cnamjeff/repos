using System;
using System.Collections.Generic;
using System.Text;

namespace KataList.CalculSalaire
{
    class CalculSalaires : IcalculSalaire
    {
        private double heureSemaineRegelementaire = 35;
        private double _salaireHoraire = 0;

        public double CalculSalaireHebdomaire(double heureTravaille,double salaireHoraire)
        {
            _salaireHoraire = salaireHoraire;

            if (heureTravaille <= heureSemaineRegelementaire && heureTravaille > 0)
            {
                return heureTravaille * _salaireHoraire;
            }
            else if (heureTravaille > heureSemaineRegelementaire)
            {
                double heureSupplementaire = CalculHeureSupp(heureTravaille);
                double salaireHeureSupplementaire = SalaireHeureSupplementaire(heureSupplementaire);                
                var totalHeureNormal = heureSemaineRegelementaire * _salaireHoraire;
                var totalSalaire = salaireHeureSupplementaire + totalHeureNormal;
                return totalSalaire;
            }
            return 0.0;
        }

        private double SalaireHeureSupplementaire(double heureSupplementaire)
        {
            double chiffre = 1.5;
            return (_salaireHoraire * chiffre) * heureSupplementaire;
        }

        private double CalculHeureSupp(double heureTravaille)
        {
            return heureTravaille - heureSemaineRegelementaire;
        }
    }
}
