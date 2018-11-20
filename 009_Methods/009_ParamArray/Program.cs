using System;

namespace _009_ParamArray
{
    class Program
    {
        static void Addition(params int[] integers)
        {
            int result = 0;
            for (int i =0; i<integers.Length; i++)
            {
                result += integers[i];
            }
            Console.WriteLine(result);
        }

        static void AdditionMas(int[] integers, int k)
        {
            int result = 0;
            for (int i = 0; i < integers.Length; i++)
            {
                result += integers[i] * k;
            }
            Console.WriteLine(result);
        }

        static void Main(string[] args)
        {
            Addition(1, 2, 3, 4, 5);

            int[] array = new int[] { 1, 2, 3, 4, 5 };
            Addition(array);
            Addition();

            // array needed and can be passed first
            AdditionMas(array, 2);

            Console.ReadLine();
        }
    }
}
