using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_Enums
{
    class Program
    {
        enum Days // int
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        enum Time : byte
        {
            Morning,
            Afternoon,
            Evening,
            Night
        }

        enum Operations
        {
            Add = 2,
            Subtract = 4,
            Multiply = 8,
            Divide = 16
        }

        static void MathOp(double x, double y, Operations op)
        {
            double result = 0;

            switch (op)
            {
                case Operations.Add:
                    result = x + y;
                    break;
                case Operations.Divide:
                    result = x / y;
                    break;
                case Operations.Multiply:
                    result = x * y;
                    break;
                case Operations.Subtract:
                    result = x - y;
                    break;
            }

            Console.WriteLine("Operation result: {0}", result);
        }

        static void Main(string[] args)
        {
            Days d;
            d = Days.Monday;
            Console.WriteLine($"{d} {d.GetType().ToString()} {(int)d}");

            Time t = Time.Night;
            Console.WriteLine($"{t} {t.GetType().ToString()} {(int)t}");

            Operations o = Operations.Add;
            Console.WriteLine($"{o} {o.GetType().ToString()} {(int)o}");

            MathOp(10, 5, Operations.Add);
            MathOp(11, 5, Operations.Multiply);

            Console.ReadLine();
        }
    }
}
