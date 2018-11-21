using System;

namespace _018_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            calc.Add(1, 2); // 3
            calc.Add(1, 2, 3); // 6
            calc.Add(1, 2, 3, 4); // 10
            calc.Add(1.2, 3.4); // 4.6

            Console.ReadLine();
        }
    }
}
