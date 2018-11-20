using System;

namespace _008_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // memory allocation
            int[] nums1 = new int[4];

            // array definition
            int[] nums2 = new int[4] { 1, 2, 3, 4 };
            int[] nums3 = new int[] { 1, 2, 3, 4 };
            int[] nums4 = new[] { 1, 2, 3, 4 };
            int[] nums5 = { 1, 2, 3, 4 };

            // getting array values
            int[] nums = new int[4];
            nums[0] = 1;
            nums[1] = 2;
            nums[2] = 3;
            nums[3] = 5;
            Console.WriteLine(nums[3]);

            // iterate through array
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            // faster way to iterate
            for (int j = 0; j < numbers.Length; j++)
            {
                numbers[j] *= 2;
                Console.Write($"{numbers[j]} \t");
            }
            Console.WriteLine();

            // multi-level arrays
            int[,] rnums1;
            rnums1 = new int[1, 1];

            int[,] rnums2 = new int[2, 3];
            int[,] rnums3 = new int[2, 3] { { 0, 1, 2 }, { 3, 4, 5 } };
            int[,] rnums4 = new int[,] { { 0, 1, 2 }, { 3, 4, 5 } };
            int[,] rnums5 = new [,] { { 0, 1, 2 }, { 3, 4, 5 } };
            int[,] rnums6 = { { 0, 1, 2 }, { 3, 4, 5 } };

            int[,,] mnums = new int[2, 3, 4];

            // iterating multi-level array
            int[,] mas = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };

            int rows = mas.GetUpperBound(0) + 1;
            int columns = mas.Length / rows;

            for (int m = 0; m < rows; m++)
            {
                for (int n = 0; n < columns; n++)
                {
                    Console.Write($"{mas[m, n]} \t");
                }
                Console.WriteLine();
            }

            // array of arrays
            int[][] anums = new int[3][];
            anums[0] = new int[2] { 1, 2 };
            anums[1] = new int[3] { 3, 4, 5 };
            anums[2] = new int[5] { 1, 2, 3, 4, 5 };

            for (int x = 0; x < anums.Length; x++)
            {
                for (int y = 0; y < anums[x].Length; y++)
                {
                    Console.Write($"{anums[x][y]} \t");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
