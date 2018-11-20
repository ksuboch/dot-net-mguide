using System;

namespace _004_ConsoleInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input name: ");
            string name = Console.ReadLine();

            Console.Write("Input age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input salary: ");
            decimal salary = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"Name: {name} Age: {age} Height: {height} Salary: {salary}$");
            Console.ReadKey();
        }
    }
}
