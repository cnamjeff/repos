using System;
using System.Collections.Generic;
using System.Text;

namespace IocCore
{
    class DAOImpl2 : IDAOImpl
    {
        public int GetValue()
        {
            var temp = 45;
            return temp;
        }
    }
}
