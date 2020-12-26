using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            //DirectoryInfo dir = new DirectoryInfo(@"C:\Users\mercu\Pictures\");
            //FileInfo[] fichiers = dir.GetFiles();

            //Assembly assembly = Assembly.GetCallingAssembly();
            //String path = assembly.Location;
            ////var value = Path.GetFileName((@"C:\Users\mercu\Pictures\voyage.png"));
            //foreach (FileInfo fichier in fichiers)
            //{   
            //    Console.WriteLine(fichier);
            //    Console.WriteLine(DateTime.UtcNow);
            //}

            //var filename = "voyage.png";
            //var sourcePath = @"C:\Users\mercu\Pictures";
            //var targetPath = @"G:\";

            //string sourceFile = System.IO.Path.Combine(sourcePath, filename);
            //string destFile = System.IO.Path.Combine(targetPath, filename);

            //if (!System.IO.Directory.Exists(targetPath))
            //{
            //    System.IO.Directory.CreateDirectory(targetPath);
            //}
            //System.IO.File.Copy(sourceFile, destFile,true);
            //var newName = "croissant.png";
            //string NewdestFile = System.IO.Path.Combine(targetPath, newName);
            //System.IO.File.Move(destFile, NewdestFile);

            //string a = "20";
            //string b = "5";
            //string total = a +"toto"+ b;
            //Console.WriteLine(total);
            //Factorielle.Factoriel(20);
            IDal dal = new DAL();
            METEO meteodujour = dal.ObtenirLaMeteoDuJour();

            Console.WriteLine(meteodujour.Tostring());
            Console.ReadLine();




        }
    }
}
