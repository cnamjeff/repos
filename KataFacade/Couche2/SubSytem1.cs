using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Couche2
{
   public class SubSytem1 : /*ACodeSource,*/ ISubSytem1
    {
        public void NameOfClass()
        {
            Console.WriteLine("Je suis dans la class SubSytem1");
        }
        public SubSystem2 SubSystem2()
        {
            return new SubSystem2();
        }


    }
}
