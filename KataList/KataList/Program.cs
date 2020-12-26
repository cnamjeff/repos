using KataList.CalculSalaire;
using KataList.ConvertDegrees;
using KataList.Date;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace KataList
{
    class Program
    {
       
        static void Main(string[] args)
        {
            //AConvert convertisseur = new Convert(1.609);
            //double resultatMille = convertisseur.ConvertKiloEnMille(1);
            //double resultatKilomètre = convertisseur.ConvertMilleEnKilo(85);
            //Console.WriteLine(Math.Round(resultatKilomètre, 4));


            //ITemperature temperatureConvert = new Temperature();
            //double Degres_Vers_Farenheit= temperatureConvert.Degres_Vers_Farenheit(2);
            //double Farenheit_vers_Degres= temperatureConvert.Farenheit_vers_Degres(55);
            //Console.WriteLine(Math.Round(Degres_Vers_Farenheit, 2));
            //Console.WriteLine(Math.Round(Farenheit_vers_Degres, 2));

            //IcalculSalaire calcul = new CalculSalaires();
            //var paye = calcul.CalculSalaireHebdomaire(40,10.5);

            //INbreJourMois jourMois = new NbreJourMois();
            //int nbreJour = jourMois.JourMois(2064,2);
            /*-----------------------------------------------------------*/
            //Solution première
            //string[] doc = Directory.GetFiles("F:", "Dossier_remboursement.pdf", SearchOption.AllDirectories);
            //List<string> document = doc.ToList();
            //if (document.Count == 0) { Console.WriteLine("Le fichier n'a pas été trouvé"); }
            //foreach (var item in doc)
            //{
            //    if (!string.IsNullOrEmpty(item))
            //    {
            //        Console.WriteLine("Le chemin du fichier est le suivant : ");
            //        Console.WriteLine(item);
            //    }              

            //}
            /*-----------------------------------------------------------*/

            /*-----------------------------------------------------------*/
            //solution deux
            //string[] doc1 = Directory.GetFiles("F:", "Dossier_remboursementz.pdf", SearchOption.AllDirectories);
            //IList<string> document1 = doc1.ToList();
            //if (document1.Count == 0) { Console.WriteLine("Le fichier n'a pas été trouvé"); }
            //else
            //{
            //    Console.WriteLine("Le chemin du fichier est le suivant : ");
            //    Console.WriteLine(doc1[0]);
            //}


            //if(File.Exists(doc[0]))
            //{
            //    Console.WriteLine(doc[0]);
            //}
            //else
            //{
            //    Console.WriteLine("null");
            //}
            IList<int> numberList =  new List<int>() { 1, 2, 3, 4, 5 };
            foreach (var number in numberList)
            {
                switch (number)
                {
                    case if number >= 1 && number <= 3:
            return "yes";
                    case if number >= 4 && number <= 5:
            return "no";
                    default:
                        return "unknown";
                }
            }

            Console.WriteLine(struct1.foo);
            Console.ReadLine();
        }
    }
   
}
