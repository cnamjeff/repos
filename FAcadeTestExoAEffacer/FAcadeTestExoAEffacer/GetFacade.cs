using Facade;
using System;
using System.Collections.Generic;
using System.Text;

namespace FAcadeTestExoAEffacer
{
    public class GetFacade : AGetFacade
    {      

        public GetFacade(Imenu menu, ICuisine cuisine) : base(menu, cuisine)
        {
           
        }
    }
}
