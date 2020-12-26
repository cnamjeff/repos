using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class Cuisine : ICuisine
    {
        public string NomCuisine()
        {
            return "créole";
        }
    }
}
