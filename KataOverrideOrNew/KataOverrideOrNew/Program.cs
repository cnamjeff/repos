using System;

namespace KataOverrideOrNew
{
    class Program
    {
        static void Main(string[] args)
        {
            var B = new B();            
            var result = ((A)B).Tostring();
            var result2 = B.Tostring();            
            Console.WriteLine(result);
            Console.WriteLine(result2);          
            Console.ReadLine();
        }
    }

    public class A
    {
        public virtual string Tostring() => "Je suis noir";
    }

    public class B : A
    {
        public new string Tostring()
        {
            return "Je suis blanc";
        } 
           
    }

    

}
