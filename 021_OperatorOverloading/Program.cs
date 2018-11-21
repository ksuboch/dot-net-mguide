using System;

namespace _021_OperatorOverloading
{
    class Counter
    {
        public int Value { get; set; }

        public static Counter operator +(Counter c1, Counter c2) => new Counter { Value = c1.Value + c2.Value };
        public static bool operator >(Counter c1, Counter c2) => c1.Value > c2.Value;
        public static bool operator <(Counter c1, Counter c2) => c1.Value < c2.Value;
        public static bool operator true(Counter c1) => c1.Value != 0;
        public static bool operator false(Counter c1) => c1.Value == 0;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Counter c1 = new Counter { Value = 23 };
            Counter c2 = new Counter { Value = 45 };

            Console.WriteLine(c1 > c2);
            Console.WriteLine((c1 + c2).Value);

            Console.ReadLine();
        }
    }
}
