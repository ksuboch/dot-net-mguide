using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_Tuples
{
    class Program
    {
        private static (string name, int age) GetValues((string n, int a) tuple, int x)
        {
            var result = (name: tuple.n, age: tuple.a + x);
            return result;
        }
        static void Main(string[] args)
        {
            var tuple = (5, 10);
            Console.WriteLine(tuple.Item1);
            Console.WriteLine(tuple.Item2);

            tuple.Item1 += 26;
            Console.WriteLine(tuple.Item1);

            var (name, age) = ("Tom", 25);

            Console.WriteLine(name);
            Console.WriteLine(age);

            var (n, a) = GetValues(("Tom", 23), 12);
            Console.WriteLine(n);
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
