using System;

namespace _005_CheckedTypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 3;
                int b = 600;
                byte c = GetC(a, b);
                Console.WriteLine($"c = {c}, c.Type {c.GetType().ToString()}");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }

        private static byte GetC(int a, int b)
        {
            return checked((byte)(a + b));
        }
    }
}
