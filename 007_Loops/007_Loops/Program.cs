using System;

namespace _007_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // for loop
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine($"i^2 = {i * i}");
            }

            // do loop
            int j = 6;
            do
            {
                Console.WriteLine(j);
                j--;
            } while (j > 0);

            // while loop
            int k = 6;
            while (k > 0)
            {
                Console.WriteLine(k);
                k--;
            }

            // break
            for (int m = 0; m < 9; m++)
            {
                if (m == 5)
                    break;
                Console.WriteLine(m);
            }

            // continue
            for (int n = 0; n < 9; n++)
            {
                if (n == 5)
                    continue;
                Console.WriteLine(n);
            }

            Console.ReadLine();
        }
    }
}
