﻿using System;

namespace SpecflowCalculator
{
    public class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        public int Add()
        {
            return FirstNumber + SecondNumber;
        }

        public int Mult()
        {
            return FirstNumber * SecondNumber;
        }

    }
}
