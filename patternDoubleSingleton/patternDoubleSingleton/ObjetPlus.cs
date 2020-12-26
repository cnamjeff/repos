using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternDoubleSingleton
{
    public abstract class ObjetPlus
    {
        public ObjetPlus(string name, string surname, string age, string taille) { }
        public ObjetPlus(string name, string surname):this(name, surname,null,null) { }
        public ObjetPlus(string name, string surname,string age):this(name, surname,age,null) { }
        public ObjetPlus(string name):this(name, null, null, null) { }

        public string Name { get; }
        public string surname { get; }
        public string age { get; }
        public string taille { get; }
    }

    public class Objet : ObjetPlus
    {
        public static Objet jfh = new Objet("jean","himmer","25", "183");
        public static Objet elo = new Objet("barbe","elo","32");
        public static Objet vins = new Objet("vins","himmer");

        public Objet(string name,string surname, string age, string taille):base(name, surname, age, taille) { }   
        public Objet(string name, string surname) : base(name,surname) { }
        public Objet(string name, string surname,string age) : base(name,surname,age) { }

    }
}
