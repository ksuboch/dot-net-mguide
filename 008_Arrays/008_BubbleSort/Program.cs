using System;

namespace _008_BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = ReadInt("Input array size: ");
            int[] numbers = new int[arraySize];

            ReadArray(numbers);
            SortArray(numbers);
            WriteArray(numbers);

            Console.ReadLine();
        }

        private static void WriteArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}\t");
            }
            Console.WriteLine();
        }

        private static int ReadInt(string msg)
        {
            Console.Write(msg);
            return Convert.ToInt32(Console.ReadLine());
        }

        private static int[] ReadArray(int[] arr)
        {
            for (int k = 0; k < arr.Length; k++)
            {
                arr[k] = ReadInt("Input value: ");
            }
            return arr;
        }

        private static void SortArray(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int tmp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = tmp;
                    }
                }
            }
        }
    }
}
