using System;
using System.Collections.Generic;
using System.Text;

namespace MemoryTestSolid
{
   public class Circle : Air
    {
        private double radius;
       
    public double Area()
        {
            return radius * radius * Math.PI;
        }

    }
}
