using System;
using System.Collections.Generic;
using System.Text;

namespace b
{
    public abstract class ObjetVélo : InterfaceInitialisationObjet
    {
        public ObjetVélo(string name, int number)
        {
            Name = name;
            Number = number;
        }

        public string Name {get; }
        public int Number {get; }

        public void Age()
        {
            throw new NotImplementedException();
        }
    }
}
