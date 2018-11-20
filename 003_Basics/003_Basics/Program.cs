using System;

namespace _003_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables
            string name = "Kirill";
            Console.WriteLine(name);

            name = "Bob";
            Console.WriteLine(name);

            // logical literals
            Console.WriteLine(true);
            Console.WriteLine(false);

            // number literals
            Console.WriteLine(-11);
            Console.WriteLine(5);
            Console.WriteLine(505);

            // binary litrals
            Console.WriteLine(0b11);     // 3
            Console.WriteLine(0b1011);   // 11
            Console.WriteLine(0b100001); // 33

            // hex literals
            Console.WriteLine(0x0A); // 10
            Console.WriteLine(0xFF); // 255
            Console.WriteLine(0xA1); // 161

            // real literals
            Console.WriteLine(3.2e3);  // 3200
            Console.WriteLine(1.2E-1); // 0.12

            // symbols
            Console.WriteLine('2');
            Console.WriteLine('\x78');   // ASCII x
            Console.WriteLine('\x5A');   // ASCII z
            Console.WriteLine('\u0411'); // Unicode Б
            Console.WriteLine('\u0421'); // Unicode C

            // strings
            Console.WriteLine("ООО \"Рога и копыта\"");
            Console.WriteLine("Hello \nWorld");

            // types
            bool alive = true;

            Console.WriteLine($"byte [{byte.MinValue};{byte.MaxValue}]");
            Console.WriteLine($"sbyte [{sbyte.MinValue};{sbyte.MaxValue}]");

            Console.WriteLine($"short [{short.MinValue};{short.MaxValue}]");
            Console.WriteLine($"ushort [{ushort.MinValue};{ushort.MaxValue}]");

            Console.WriteLine($"int [{int.MinValue};{int.MaxValue}]");
            Console.WriteLine($"uint [{uint.MinValue};{uint.MaxValue}]");

            Console.WriteLine($"long [{long.MinValue};{long.MaxValue}]");
            Console.WriteLine($"ulong [{ulong.MinValue};{ulong.MaxValue}]");

            Console.WriteLine($"float [{float.MinValue};{float.MaxValue}]");
            Console.WriteLine($"double [{double.MinValue};{double.MaxValue}]");
            Console.WriteLine($"decimal [{decimal.MinValue};{decimal.MaxValue}]");

            // suffixes
            float a = 3.14F;
            Console.WriteLine($"a - {a.GetType().ToString()}");
            float b = 30.6f;
            Console.WriteLine($"b - {b.GetType().ToString()}");

            uint c = 10U;
            Console.WriteLine($"c - {c.GetType().ToString()}");
            long d = 20L;
            Console.WriteLine($"d - {d.GetType().ToString()}");
            ulong e = 30UL;
            Console.WriteLine($"e - {e.GetType().ToString()}");

            // system types
            System.Int32 f = 4;
            Console.WriteLine($"f - {f.GetType().ToString()}");

            // implicit typing
            var hello = "Hell or World";
            Console.WriteLine($"hello - {hello.GetType().ToString()}");

            var g = 20;
            Console.WriteLine($"g - {g.GetType().ToString()}");

            Console.ReadLine();
        }
    }
}
