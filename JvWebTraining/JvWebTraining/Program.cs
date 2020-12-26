using System;
using System.Collections.Generic;
using System.Linq;

namespace JvWebTraining
{
   public interface Pot
    {
        void Couleur();
        int Number { get; set; }
    }

    abstract class Pet : Pot
    {
        protected int x;
        // Initialize a readonly field
        protected readonly int y = 25;
        protected readonly int z;

        public Pet(int p1, int p2, int p3)
        {
            x = p1;
            y = p2;
            z = p3;
        }
        public Pet(int p1, int p2)
        {
            x = p1;
            y = p2;
           
        }
        public abstract int Number { get ; set; }

        public void Couleur()
        {
            throw new NotImplementedException();
        }
        public abstract void Mail();
    }

    class Cat : Pet
    {
        public override int Number { get; set; }
        public Cat(int p1, int p2, int p3):base(p1,p2,p3)
        {
            
        }

        public Cat(int p1, int p2) : base(p1, p2)
        {

        }
        public override void Mail()
        {
            throw new NotImplementedException();
        }
    }

    class Dog : Pet
    {
       

        public override void Mail()
        {
            throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] valueCharacter = new string[] { "5", "8", "9", "65", "78", "789" };
            int[] valueNumber = new int[] {5, 8, 9, 65, 78, 789 };

            int numberMax = 0;
            foreach (var number in valueNumber)
            {
                if (number> numberMax)
                {
                    numberMax = number;
                }
            }

            Console.WriteLine(numberMax);
            Console.ReadLine();
        }
    }
}
