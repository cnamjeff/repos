using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestJeff14112019
{
    public abstract class VehiculeAbstract
    {
        public VehiculeAbstract(string name, string surname, int annee)
        {
            this.Name = name;
            this.Surname = surname;
            this.Annee = annee;
        }

        public VehiculeAbstract(string name) : this(name, null, 0) { }

        public string Name { get; }
        public string Surname { get; }
        public int Annee { get; }
    }
}
