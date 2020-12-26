using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestJeff14112019
{
    public class CreateVehicule : VehiculeAbstract
    {
        public static CreateVehicule velo = new CreateVehicule("velo", "velib", 2002);
        public static CreateVehicule moto = new CreateVehicule("moto", "bécane", 2010);
        public static CreateVehicule bateau = new CreateVehicule("bateau");

        public CreateVehicule(string name) : base(name)
        {
        }

        public CreateVehicule(string name, string surname, int annee) : base(name, surname, annee)
        {
        }

    }
}
