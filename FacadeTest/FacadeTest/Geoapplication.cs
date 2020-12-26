using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeTest
{
   public class Geoapplication
    {
        
        public Geoapplication(
            Menu menu,
            Inspector inspector)
        {
            _Menu = menu;
            _Inspector = inspector;
        }

        public Menu _Menu { get; }
        public Inspector _Inspector { get; }
    }
}
