using System;
using System.Collections.Generic;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillValueAgixis
{
    #region Generic<Person>
    class Person
    {
     
        public Person(String name)
        {
            Console.WriteLine(name);
        }
    }
    class Generic<T> where T : new ()
    {
        public T Request()
        {
            return new T();
        }
    }
    #endregion Generic<Person>

    #region Animation bishop
    interface IMovable
    {
        void Move(int x, int y);
    }
    class  Animation : IMovable
    {
        public int X { get; set; } = 0;
        public int Y { get; set; } = 0;
        public  void Move(int x, int y)
        {
            Console.WriteLine("X={x} / Y={y}");
            X = x;
            Y = y;
        }
    }
    #endregion Animation bishop
   
    #region dillanBalance
    public class Client
    {
        public String Name { get; set; }
        public BankAccount Account { get; set; }

    }
    public class BankAccount
    {
        public Decimal Balance { get; set; } = 99.9m;
    }
    #endregion dillanBalance

    //#region Movable
    //class MyClass<T> where T : Point
    //{
    //    public void Print (T p) { p.Print(); }
    //}
    //interface Movable
    //{
    //    Point Move(int xOffset, int yOffset);
    //}
    //struct Point : Movable
    //{
    //    int x, y;
    //    public Point(int x, int y)
    //    {
    //        this.x = x;
    //        this.y = y;
    //    }
    //    public void Print()
    //    {
    //        Console.WriteLine("x ={0}, y={1}", x, y);
    //    }
    //    public Point Move(int xOffset, int yOffset)
    //    {
    //        return new Point(x + xOffset, y + yOffset);
    //    }
    //}
    //#endregion Movable

    #region Derived
    class Base { }
    class Derived : Base { }
    #endregion Derived

    class Program
    {
#region parametreOptional
        public void SendMail(string toAddress, string bodyText,bool ccAdministrator =true,bool isBodyhtml =false)
        {
            //la déclaration est valable parce que les paramètres optionnels sont valables
        }
#endregion parametreOptional
        static void Main(string[] args)
        {
            //-------------------------------------------------//
            //-------------------Generic<Person>------------------------//
            //Generic<Person> instance = new Generic<Person>();
            //Console.WriteLine(instance.Request().GetType()); //erreur de compile car il manque le constructeur sans parametre

            //-------------------------------------------------//
            //-------------------Animation bishop------------------------//
            //Animation bishop = new Animation();
            //bishop.Move(5, 6);
            //Console.WriteLine($"Bishop X = {bishop.X} / Bishop Y = {bishop.Y}"); // résutalt : X={x} / Y={y} Bishop X = 5 / Bishop Y =6

            //-------------------------------------------------//
            //-------------------dillanBalance------------------------//
            //Client dillan = new Client() { Name = "Dillan" };
            //Nullable<Decimal> dillanBalance = dillan?.Account?.Balance;
            //Console.WriteLine($"New client created:{dillan?.Name} with balance {dillanBalance}"); // result is "New client created:Dillan with balance"

            //-------------------------------------------------//
            //-------------------Movable------------------------//
            //var c = new MyClass<Point>();
            //var p = new Point(1, 2);
            //c.Print(p.Move(3, 4)); 
            // result is erreur de compilation : "Point" n'est pas une contrainte valide. Un type utilisé comme une contrainte doit être une interface, une classe non scellée ou un paramètre de type


            //-------------------------------------------------//
            //-------------------s1 == s2, s3 == s4, s3.Equals(s4), s1 == s4------------------------//
            //string s1 = "string";
            //string s2 = "string";
            //char[] cs = { 's', 't', 'r', 'i', 'n', 'g' };
            //String s3 = new string(cs);
            //String s4 = new string(cs);
            //Console.WriteLine("s1==s2 > {0}; s3 == s4 > {1}; s3.Equals(s4) > {2}; s1 == s4 > {3}",
            //    s1 == s2, s3 == s4, s3.Equals(s4), s1 == s4);
            ////the result is s1==s2 > true; s3 == s4 > true; s3.Equals(s4) > true; s1 == s4 > true

            //-------------------------------------------------//
            //-------------------list.Where(c => c.Length == 3)------------------------//
            //string[] colors = { "green", "brown", "blue", "red" };
            //var list = new List<string>(colors);
            //IEnumerable<string> query = list.Where(c => c.Length == 3);
            //list.Remove("red");
            //Console.WriteLine(query.Count()); // the result is 0



            //-------------------------------------------------//
            //-------------------OrderBy(c => c.Length).Where(c => c.Length == 4).Single()------------------------//
            //string[] colors = { "green", "brown", "blue", "red" };
            //var result = colors.OrderBy(c => c.Length).Where(c => c.Length == 4).Single();
            //Console.WriteLine(result);
            // the result is blue

            //-------------------------------------------------//
            //------------------- from c in items
            //-------------- where c.Length > 3
            //--------------orderby c.Length
            //--------------select c.Length;------------------------//
            //string[] items = { "item1", "item2", "item3", "item4" };
            //var query =
            //    from c in items
            //    where c.Length > 3
            //    orderby c.Length
            //    select c.Length;
            //foreach (var item in query)
            //{
            //    Console.WriteLine(item);
            //}
            // the result is 5 5 5 5 et il est de type enumerable string

            //-------------------------------------------------//
            //-------------------list.Add("item3")------------------------//
            //var list = new List<string>() { "item1", "item2" };
            //foreach (var item in list)
            //{
            //    list.Add("item3");
            //}
            // the result is a error  "System.InvalidOperationException : 'Collection was modified; enumeration operation may not execute"

            //-------------------------------------------------//
            //-------------------Derived------------------------//
            //Action<Base> b = (target) => { Console.WriteLine(target.GetType().Name); };
            //Action<Derived> d = b;
            //d(new Derived());// the result is "Derived" et ca compile très bien

            //-------------------------------------------------//
            //-------------------ParcoursList------------------------//
            //var values = new List<int> { 100, 110, 120 };
            //var funcs = new List<Func<int>>();
            //foreach (var v in values)
            //{
            //    funcs.Add(() => v);
            //}
            //foreach (var f in funcs)
            //{
            //        Console.WriteLine(string.Format("{0}", f()));
            //}
            ////the result is : 100 110 120
            ///

            //-------------------------------------------------//
            //-------------------taskA------------------------//
            //Task<DateTime> taskA = new Task<DateTime>(() => DateTime.Now);
            //Task continuation = taskA.ContinueWith((result) =>
            //{
            //    return result.ToString();
            //});
            //taskA.Start();
            ////result est de type Task<DateTime>

            Console.ReadLine();
        }
    }
}
