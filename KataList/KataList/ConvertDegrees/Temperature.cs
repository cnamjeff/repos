using System;
using System.Collections.Generic;
using System.Text;

namespace KataList.ConvertDegrees
{
    class Temperature : ITemperature
    {
        public double Degres_Vers_Farenheit(double degres)
        {
            double farenheit = (degres * 9 / 5) + 32;
            return farenheit;
        }

        public double Farenheit_vers_Degres(double farenheit)
        {
            double degres = (farenheit - 32) * 5 / 9;
            return degres;
        }
    }
}
