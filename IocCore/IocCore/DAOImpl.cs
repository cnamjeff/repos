using System;
using System.Collections.Generic;
using System.Text;

namespace IocCore
{
    class DAOImpl : IDAOImpl
    {
        public int GetValue()
        {
            var temp = 12;
            return temp;
        }
    }
}
