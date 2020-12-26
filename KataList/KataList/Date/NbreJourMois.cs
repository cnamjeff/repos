using System;
using System.Collections.Generic;
using System.Text;

namespace KataList.Date
{
    class NbreJourMois : INbreJourMois
    {
        public int JourMois(int annee, int mois)
        {
            switch (mois)
            {
                case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                    return 31;
                case 4: case 6: case 9: case 11:
                    return 30;
                case 2:
                    if (bisextile(annee)) { return 28; }
                    else { return 29; }                                 
                default:
                    return 0;
            }          
        }

        private bool bisextile(int annee)
        {
            return annee % 4 == 0 && ((annee % 100 != 0) || (annee % 400 == 0));
        }
    }
}
