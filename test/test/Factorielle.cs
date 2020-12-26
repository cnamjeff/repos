using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    static class Factorielle
    {

        public static int Factoriel(int a)
        {
            if (a <= 1)
                return 1;
            return a * Factoriel(a - 1);
        }
    }
}
