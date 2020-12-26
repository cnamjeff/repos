using MemoryTestSolid;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MemoryTestSolid
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ////calculated
            //int result = 5 + 6;
            ////Display of the result
            //Console.WriteLine(Convert.ToString(result));
            //Console.ReadLine();

           int tabmax = 0;
            List<int> tab = new List<int>() { 2, 5, 7, 89, 5, 2, 9, 78, 45, 12 };
           int maxLinq = tab.Max();

            //or

            for (int i = 0; i < 10; i++)
            {
                if (tab[i] > tabmax)
                {
                    tabmax = tab[i];
                }
            }

            Console.WriteLine(tabmax);
            Console.WriteLine(maxLinq);
            Console.ReadLine();
        }


        public void ExempleStupid()
        {
            

        }


    }
}
