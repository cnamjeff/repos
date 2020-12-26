using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class METEO
    {
        public double Temperature { get; set; }
        public Temps temps { get; set; }

        public string Tostring()
        {
            return string.Format("il y a du {0} avec {1} degrès", temps, Temperature);
        }
    }
}
