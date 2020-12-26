using Facade;
using System;

namespace FAcadeTestExoAEffacer
{

    class Program
    {
        static void Main(string[] args)
        {

            ICuisine cuisine = new Cuisine();
            Imenu menu = new Menu();


            AGetFacade facade = new GetFacade(menu, cuisine);
            Console.WriteLine(facade._cuisine.NomCuisine());
            Console.WriteLine(facade._menu.nomMenu());
            Console.ReadLine();
        }
    }
}
