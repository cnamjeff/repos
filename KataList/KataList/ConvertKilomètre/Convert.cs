using System;
using System.Collections.Generic;
using System.Text;

namespace KataList
{
    internal class Convert : AConvert
    {
        private readonly double _valueConvert;
        public Convert(double valueConvert)
        {
            _valueConvert = valueConvert;
        }
        public double ConvertKiloEnMille(double valueInKilometre)
        {
            return valueInKilometre / _valueConvert;
        }

        public double ConvertMilleEnKilo(double valueInMile)
        {
            return valueInMile * _valueConvert;
        }
    }
}
