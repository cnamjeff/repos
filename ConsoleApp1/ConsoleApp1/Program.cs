using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var some = 1;
            Console.WriteLine("quel ton chiffre ?");
            string saisie = Console.ReadLine();
            int nbre = int.Parse(saisie);
            List<int> sommeEntier = new List<int>();
            Console.WriteLine("calcul de la somme des entiers juqu'au nombre choisi ?");
            Console.WriteLine("les chiffre sont ");
            for (int i=1 ;i<= nbre; i++)
            {
                sommeEntier.Add(i);
                Console.WriteLine(i+"\n ");

                some = some*i; 
            }


            Console.WriteLine("le chiffre que l'on cherche est le : "+ some);


            Console.ReadLine();
        }
    }
}
