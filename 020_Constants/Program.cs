using System;

namespace _020_Constants
{
    class MathLib
    {
        public const double PI = 3.14;
        public const double E = 2.71;
        public readonly double stored;

        public MathLib(double str)
        {
            stored = str;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MathLib.E);

            MathLib m = new MathLib(1.2);
            Console.WriteLine(m.stored);

            Console.ReadLine();
        }
    }
}
