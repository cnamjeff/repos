using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Claims;

namespace test
{
    public class DAL : IDal
    {
        
        public METEO ObtenirLaMeteoDuJour()
        {
            try
            {
               METEO meteo = new METEO { Temperature = 22, temps = Temps.Soleil };
                return meteo;                 

            }
            catch (Exception)
            {

                throw new NotImplementedException();
            }           

        }          
       
      
    }
}
