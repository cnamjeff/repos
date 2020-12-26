using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Couche2
{
   public class SubSystem2 :/* ACodeSource,*/ ISubSystem2
    {
       

        public void NameOfClass()
        {
            Console.WriteLine("Je suis dans la class SubSytem2");
        }

        public SubSystem3 subSystem3 { get; set; }
    }
}
