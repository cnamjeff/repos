using System;
using System.Collections.Generic;
using System.Text;

namespace ZCouche2
{
    public abstract class MaisonMega
    {
        protected MaisonMega(string objet, int numSalle)
        {
            Objet = objet;
            NumSalle = numSalle;
        }
        public string Objet {get; }
        public int NumSalle {get; }
    }
}
