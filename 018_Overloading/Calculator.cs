﻿using System;

namespace _018_Overloading
{
    class Calculator
    {
        public void Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine($"Resilt is {result}");
        }

        public void Add(int a, int b, int c)
        {
            int result = a + b + c;
            Console.WriteLine($"Resilt is {result}");
        }

        public void Add(int a, int b, int c, int d)
        {
            int result = a + b + c + d;
            Console.WriteLine($"Resilt is {result}");
        }

        public void Add(double a, double b)
        {
            double result = a + b;
            Console.WriteLine($"Resilt is {result}");
        }
    }
}
