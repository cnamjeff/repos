using CouplageFort.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouplageFort.Interface
{
    public interface IMetierImpl
    {
        int Calcul();
        IDAOImpl Dao { get; set; }
    }
}
