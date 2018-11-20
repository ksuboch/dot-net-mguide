using System;

namespace _009_Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            int j = 15;
            Console.WriteLine(Sum(i, j));

            Sum(ref i, i);
            Console.WriteLine(i);

            int area;
            int perimeter;
            GetData(10, 15, out area, out perimeter);
            Console.WriteLine($"Area: {area}; Perimeter: {perimeter}");

            Console.ReadLine();
        }

        static int Sum(int x, int y)
        {
            return x + y;
        }

        static void Sum(ref int x, int y)
        {
            x += y;
        }

        static void GetData(int x, int y, out int area, out int perimeter)
        {
            area = x * y;
            perimeter = 2 * (x + y);
        }
    }
}
