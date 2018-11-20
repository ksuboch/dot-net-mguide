using System;

namespace _010_Recursion
{
    class Program
    {
        static int Factorial(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }

        static int Fibonacci(int x)
        {
            if (x == 0)
            {
                return 0;
            }
            else if (x == 1)
            {
                return 1;
            }
            else
            {
                return Fibonacci(x - 1) + Fibonacci(x - 2);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(1));
            Console.WriteLine(Factorial(5));
            Console.WriteLine(Factorial(10));

            Console.WriteLine(Fibonacci(1));
            Console.WriteLine(Fibonacci(5));
            Console.WriteLine(Fibonacci(10));

            Console.ReadLine();
        }
    }
}
