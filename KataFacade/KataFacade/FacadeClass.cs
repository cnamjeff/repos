using Couche2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataFacade
{
   internal sealed class FacadeClass : AFacadeClass, IFacadeClass
    {
      
        public FacadeClass(SubSytem1 subSytem1, SubSystem2 subSystem2, SubSystem3 subSystem3):base(subSytem1, subSystem2, subSystem3)
        {
            
        }

        public void MethodSubSystem1()
        {
            _SubSystem1.NameOfClass();
        }

        public void MethodSubSystem2()
        {
            _SubSystem2.NameOfClass();
        }

        public void MethodSubSystem3()
        {
            _SubSystem3.NameOfClass();
        }
    }
}
