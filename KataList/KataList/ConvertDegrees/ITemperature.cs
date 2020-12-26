using System;
using System.Collections.Generic;
using System.Text;

namespace KataList.ConvertDegrees
{
    interface ITemperature
    {
        double Farenheit_vers_Degres(double farenheit);
        double Degres_Vers_Farenheit(double degres);
    }
}
