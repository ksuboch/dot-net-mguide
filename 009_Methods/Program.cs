using System;

namespace _009_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintHelloWorld();
            Console.WriteLine(GetHello());
            Console.WriteLine(Sum(1, 2));
            Display("Tom", 20);
            Console.WriteLine(OptionalParam(2, 3));
            Console.WriteLine(OptionalParam(2, 3, 10));
            Console.WriteLine(OptionalParam(2, 3, s:5));
            Console.WriteLine(OptionalParam(2, 3, s: 5, z: 10));
            WaitForEnter();
        }

        static void PrintHelloWorld() => Console.WriteLine("Hello world");
        static void WaitForEnter() => Console.ReadLine();

        // return
        static string GetHello()
        {
            return "Hello";
            Console.Write("Returned hello");
        }

        static int Sum(int x, int y)
        {
            return x + y;
        }

        static void Display(string name, int age)
        {
            Console.WriteLine($"Name: {name} Age: {age}");
        }

        static int OptionalParam(int x, int y, int z = 5, int s = 4)
        {
            return x + y + z + s;
        }
    }
}
