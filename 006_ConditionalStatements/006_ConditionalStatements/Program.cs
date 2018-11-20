using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // if
            int num1 = 8;
            int num2 = 6;

            if (num1 > num2)
            {
                Console.WriteLine($"{num1} > {num2}");
            }

            // if - else
            num1 = 6;
            num2 = 8;

            if (num1 > num2)
            {
                Console.WriteLine($"{num1} > {num2}");
            }
            else
            {
                Console.WriteLine($"{num1} < {num2}");
            }

            // if - else if - else
            num1 = 3;
            num2 = 3;

            if (num1 > num2)
            {
                Console.WriteLine($"{num1} > {num2}");
            }
            else if (num1 < num2)
            {
                Console.WriteLine($"{num1} < {num2}");
            }
            else
            {
                Console.WriteLine($"{num1} = {num2}");
            }

            // switch - case
            Console.Write("Press Y or N:");
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "Y":
                    Console.WriteLine("You pressed Y");
                    break;
                case "N":
                    Console.WriteLine("You pressed N");
                    break;
                default:
                    Console.WriteLine("Unknown symbol");
                    break;
            }

            // goto case
            int number = 1;
            switch (number)
            {
                case 1:
                    Console.WriteLine("case 1");
                    goto case 5;
                case 3:
                    Console.WriteLine("case 3");
                    break;
                case 5:
                    Console.WriteLine("case 5");
                    break;
                default:
                    Console.WriteLine("default");
                    break;
            }

            // ternary operation
            int x = 2;
            int y = 3;
            Console.WriteLine("Press + or - ");
            selection = Console.ReadLine();

            int z = selection == "+" ? (x + y) : (x - y);
            Console.WriteLine(z);

            Console.ReadLine();
        }
    }
}
