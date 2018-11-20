using System;

namespace _008_CountPlus
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
            int result = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                {
                    result ++;
                }
            }

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
