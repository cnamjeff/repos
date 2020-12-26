using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPatternJeff
{
    public class MinObjet : Objet
    {
        public static MinObjet jfh = new MinObjet("jeff", "Himmer", null);
        public static MinObjet Elo = new MinObjet("Elo", "Barbe",null);
        public static MinObjet Vins = new MinObjet("Vincent","himmer","25");

        public MinObjet(string name, string surname) : base (name,surname)
        {
           
        }
        public MinObjet(string name) : base(name) { }
        public MinObjet(string name, string surname, string color) : base(name, surname,color) { }
    }
}
