using System;

namespace _008_ArrayReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            int len = numbers.Length;
            int mid = len / 2;
            PrintArray(numbers);

            for (int i = 0; i < mid; i++)
            {
                int tmp = numbers[len - i - 1];
                numbers[len - i - 1] = numbers[i];
                numbers[i] = tmp;
            }
            PrintArray(numbers);

            Array.Reverse(numbers);
            PrintArray(numbers);

            Console.ReadLine();
        }

        private static void PrintArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]}\t");
            }
            Console.WriteLine();
        }
    }
}
