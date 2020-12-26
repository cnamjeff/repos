using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace CodingGameGuarani
{
    //public abstract class A
    //{
    //    public A() { }
    //    public void Tata() { int toto = 2; }
    //    public string str;
    //}
    //public class B : A
    //{
    //    public B() { }
    //    public int zero;
    //}
    //class C
    //{


    //}

    interface Toto : Bebe, Cece, Dede { }
    interface Bebe { }
    interface Cece { }
    interface Dede { }
    public interface toto
    {
        public string First()
        {
            var toto = "";
            return toto;
        }
    }
    public abstract class Base
    {
        public abstract void Tata();
        public void Foo() { int toto = 2; }
    }

    public class Bar : Base
    {
        public override sealed void Tata() { }

    }

    class Program
    {
        //public const int MAXI = 100;

        #region ClosestToZero
        private static int ClosestToZero(int[] ent)
        {

            var number = 0;
            var increment = 0;

            if (ent[0] == 0)
            {
                return 0;
            }
            foreach (var item in ent)
            {
                if (increment == 0 && item > 0)
                {
                    increment = 1;
                    number = item;
                }

                else
                {
                    if (item < number && item > 0)
                    {
                        number = item;
                    }
                    if (item < 0 && item < number)
                    {

                    }
                }

            }
            #endregion

            return number;
        }
        #region Calc
        public static int Calc(int[] array, int n1, int n2)
        {
            var Sum = 0;


            for (int i = n1; i <= n2; i++)
            {

                if (n1 >= 0 && array[i] >= n1 && array[i] <= n2 && n1 <= n2 && n2 < array.Length)
                {
                    Sum = Sum + array[i];
                }
            }
            return Sum;
        }
        #endregion

        #region Count
        public static int Count(int n)
        {
            Base bar = new Bar();
            int resultat;

            return resultat = n >= 2 && n <= 10_000 ? n * (n - 1) / 2 : 0;

            //or
            //if (n>=2 && n<=10_000)
            //{
            //     return resultat = n * (n - 1) / 2;
            //}          

            //return 0;
        }
        #endregion 

        #region findSmallestInterval
        private static int FindSmallestInterval(int[] tabList)
        {

            int smallestInterval = 2_147_483_647;
            int capaciteMax = 2_147_483_647;

            if (tabList.Length > 2 && tabList.Length < 10_000)
            {
                foreach (var number in tabList)
                {
                    for (int num = tabList.Length; num == 0; num--)
                    {
                        if (tabList[num] > number)
                        {
                            int result = tabList[num] - number;
                            if (result < smallestInterval && smallestInterval < capaciteMax) { smallestInterval = result; }
                        }
                        else if (number > tabList[num])
                        {
                            int result = number - tabList[num];
                            if (result < smallestInterval && smallestInterval < capaciteMax) { smallestInterval = result; }
                        }
                    }

                }

            }

            return smallestInterval;
        }

        #endregion
        public static int[] FilterDuplicates(int[] data)
        {
            List<int> maList = new List<int>();
            if (data != null)
            {
                for (int i = 0; i < data.Length; i++)
                {
                    if (!maList.Contains(data[i]))
                    {
                        maList.Add(data[i]);
                    }
                }
            }
            return maList.ToArray();
        }

        #region Calcul condition égal à 1
        public bool Value(int i, int j)
        {
            if (i == 1 || j == 1 || i + j == 1)
            { 
                return true; 
            }
            return false;
        }
        #endregion

        public static int FindLargest(int[] numbers)
        {
            int maxNumber = default;
            foreach (int i in numbers)
            {
                if (maxNumber < i)
                {
                    maxNumber = i;
                }
            }
            return maxNumber;
        }

        #region Struct
        struct Struct
        {
            public int foo;
        }

        #endregion

        #region ComputeMultiplesSum
        public static int ComputeMultiplesSum(int n)
        {
            int _n = n;
            int total = 0;
            if (_n > 0 && _n < 1000)
            {
                for (int i = 0; i < _n; i++)
                {
                    if (_n % 5 == 0)
                    {
                        total = total + _n;
                        _n = _n - 1;
                    }
                }
            }
            return total;
        }

        #endregion

        #region RetourneLePlusgrandNombre
        //private int FindLargest(int[] numbers)
        //{
        //    int maxNumber = 0;
        //    foreach (var number in numbers)
        //    {
        //        if (maxNumber < number)
        //        {
        //            maxNumber = number;
        //        }
        //    }
        //    return maxNumber;
        //}
        #endregion

        private static string LonguestCommonEnding(string s1, string s2)
        {
         

            String result = "";

            if (s1 != null && s2 != null)
            {
                int i = s1.Length;
                int j = s2.Length;
                while (i != 0 && j != 0)
                {
                    if (String.Equals(s1.Substring(i - 1), s2.Substring(j - 1)) ){
                        result = s1.Substring(i - 1);
                    }
                    else
                    {
                        break;
                    }
                    i--;
                    j--;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            //-------------------------------------------------//
            //-------------------LonguestCommonEnding------------------------//
            //Console.WriteLine(LonguestCommonEnding("multiplication", "ration"));

            //-------------------------------------------------//
            //-------------------var m = new Dictionary<object, int>();------------------------//
            //var m = new Dictionary<object, int>();
            //var o1 = new object();
            //var o2 = o1;
            //m[o1] = 1;
            //m[o2] = 2;           
            //Console.WriteLine(m[o1]); // le resultat provoque est 2


            //-------------------------------------------------//
            //-------------------Struct------------------------//
            //Struct struct1;
            //struct1.foo = 5;

            //Struct struct2 = struct1;
            //struct2.foo = 10;
            //Console.WriteLine(struct1.foo);
            // le resultat est 5


            //-------------------------------------------------//
            //-------------------chemin pour rechercher un fichier et rapporter le chemin absolu puis le nom du fichier------------------//

            //string[] paths = Directory.GetFiles(@"F:\tmp\documents", "Dossier_remboursement.pdf", SearchOption.AllDirectories);
            //if(!string.IsNullOrEmpty(paths[0]))
            //Console.WriteLine(paths[0]);
            //Console.WriteLine(Path.GetFileName(paths[0]));

            //int[] ints = { -9, 8, 2, -5, 7 };

            //-------------------------------------------------//
            //-------------------FilterDuplicates------------------//
            //int[] ints = { 7, 3, 6, 4, 3, 3, 4, 9 };
            //int[] listResult = FilterDuplicates(ints);
            //foreach (var result in listResult)
            //{
            //    Console.WriteLine(result);
            //}

            //int result = ClosestToZero(ints);

            //-------------------------------------------------//
            //-------------------OptimalChange------------------//
            Change change = OptimalChange(33);
            if (change.nullelable == null)
            {
                Console.WriteLine("null");
            }
            else
            {

                Console.WriteLine("on n'a besoin de " + change.coin2 + " pièce de 2");
                Console.WriteLine("on n'a besoin de " + change.bill5 + " billet de 5");
                Console.WriteLine("on n'a besoin de " + change.bill10 + " billet de 10");
            }

            //int i1 = 5;
            //int i2 = 2;
            //int i3 = i1 / i2;
            //Console.WriteLine(i3);
            //resultat est 2

            //int[] array = { 0, 1, 2, 3, 4, 5, 3 };

            //Console.WriteLine(Calc(array, 0, 5));...

            //Console.WriteLine(Count(4)); //resultat attendu 6 pour la valeur 4

            //-------------------------------------------------//
            //-------------------trouver le plus petit interval------------------//
            //int[] tab = { 1, 6, 4, 8, 2 };
            //Console.WriteLine(FindSmallestInterval(tab));

            //-------------------------------------------------//
            //-------------------Decalage vers la droite------------------//
            /*  Console.WriteLine(2 >> 1);*/ //le resultat est 1

            //-------------------------------------------------//
            //-------------------Decalage vers la gauche------------------//
            /*  Console.WriteLine(1 << 2);*/ //le resultat est 4

            //---------------------------------------------------------//
            //-------------------FindLargest--------------------//
            //int[] numbers = { 1, -28, 88, 200, 7 };
            //int result = FindLargest(numbers);
            //Console.WriteLine(result);

            //-------------------------------------------------//
            //-------------------Max(c => c.Length------------------//
            // resultat est 10 car il calcule le nombre du mot le plus grand qui est ici kiwiaaaaaa
            //var data = new[] { "pomme", "abrico", "orangea", "kiwiaaaaaa" }.Max(c => c.Length); 



            //-------------------------------------------------//
            //-------------------hashSet------------------------//
            //var hashSet = new HashSet<int>();
            //hashSet.Add(1);
            //hashSet.Add(1);
            //hashSet.Add(2);
            //Console.WriteLine(hashSet.Count); //result 2 car c'est un hashSet et qu'il y a deux valeurs identiques.

            //----------------------------------------------------------------------//
            //-------------------Quel est la sortie de code------------------------//
            //List<string> uneListe = new List<string> { { "Categorie A" }, { "Categorie B" } };
            //IEnumerable<string> maListeFiltree = uneListe.Select(_ => _.ToLowerInvariant());
            //uneListe.Add("Categorie C");
            //Console.WriteLine(string.Join(',', maListeFiltree));// Le résultat est "catégorie a, catégorie b, catégorie c"


            //----------------------------------------------------------------------//
            //-------------------try catch finally acd------------------------//
            //try
            //{
            //    Console.WriteLine("A");
            //    int value = int.Parse("8A");
            //    Console.WriteLine("B");
            //}
            //catch
            //{
            //    Console.WriteLine("C");
            //    return;
            //}
            //finally
            //{
            //    Console.WriteLine("D");
            //}

            //Console.WriteLine("E");
            //// résultat donne ACD

            //----------------------------------------------------------------------//
            //-------------------i++------------------------//
            //int i = 0;
            //Console.WriteLine(i++);
            //Le resultat est 0

            //----------------------------------------------------------------------//
            //-------------------hashSet.Count------------------------//
            var hashSet = new HashSet<int>();
            hashSet.Add(1);
            hashSet.Add(1);
            hashSet.Add(4);
            Console.WriteLine(hashSet.Count);
            le resultat est 2
                for (int i = 0; i < hashSet.Count; i++)
            {

            }


            Console.ReadLine();
        }

        //#region OptimalChangeMoney
        //                 // Do not modify this method​​​​​​‌​​​‌‌​‌‌‌‌​‌‌‌​‌​​​​‌​‌‌ signature
        public static Change OptimalChange(int s)
        {
            const int cinq = 5;
            const int dix = 10;
            const int deux = 2;
           
            Change change = new Change();
            //return null si s = 1 ou s =3
            if ( s == 1 || s == 3)
            {
                change.nullelable = null;
                return change;
            }
            //return 4 piece de 2 si s = 8
            if(s == 8)
            {
                change.coin2 = 4;
                return change;
            }
            //return 3 piece de 2 si s = 8
            if (s == 6)
            {
                change.coin2 = 3;
                return change;
            }

            if (s >= dix)
            {
                change.bill10 = s / dix;
                //reste 1
                 if( s% 10 == 1)
                {
                    if(change.bill10 != 0)
                    {
                        change.bill10 = change.bill10 - 1;
                    }
                    
                    change.bill5 = 1;
                    change.coin2 = 3;
                    return change;
                }
                 //reste 3
                if (s % 10 == 3)
                {
                    if (change.bill10 != 0)
                    {
                        change.bill10 = change.bill10 - 1;
                    }

                    change.bill5 = 1;
                    change.coin2 = 4;
                    return change;
                }
                //6
                if (s % 10 == 6)
                {                 
                    change.coin2 = 3;
                    return change;
                }

                //8
                if (s % 10 == 8)
                {
                    change.coin2 = 4;
                    change.bill5 = 0;
                    return change;
                }

                // fonctionnement nominale

                if (s % 10 >= cinq)
                {
                    change.bill5 = (s % dix) / cinq;
                    if ((s % dix) % cinq >= deux)
                    {
                        change.coin2 = ((s % dix) % cinq) / deux;                      
                    }
                }
                else if (s % dix >= deux)
                {
                    change.coin2 = (s % dix) / deux;
                }
               
            }
            else if (s >= cinq && s < dix)
            {
                change.bill5 = s / cinq;
                if (s % cinq >= deux)
                {
                    change.coin2 = (s % cinq) / deux;
                }
            }
            else if (s > deux && s < cinq)
            {
                change.coin2 = s / deux;
            }
            return change;
        }

    }

    public class Change
    {
        public long coin2 = 0;
        public long bill5 = 0;
        public long bill10 = 0;      
        public string nullelable = "";
    }

    //#endregion


}


