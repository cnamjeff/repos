using System;

namespace ConsoleAppInjectionDependance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CalculateurService calculateurService = new CalculateurService();
            calculateurService.ParamètresMonteur = null;
        }
    }
}
