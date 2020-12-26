using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPatternJeff
{
    public abstract class Objet
    {
        public Objet(string name, string surname, string color)
        {
            this.Name = name;
            this.Surname = surname;
            this.Color = color;
        }

        public Objet(string name) : this(name, null, null)
        { }
        public Objet(string name,string surname) : this(name, surname, null)
        { }
      

        public string Name { get; }
        public string Surname { get; }
        public string Color { get; }
    }
}
