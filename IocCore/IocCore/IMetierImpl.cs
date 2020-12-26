using System;
using System.Collections.Generic;
using System.Text;

namespace IocCore
{
    public interface IMetierImpl
    {
        int Calcul();
        IDAOImpl Dao { get; set; }

    }
}
