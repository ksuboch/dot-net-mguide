using System;

namespace _024_Inheritance
{
    class Person
    {
        string Name;
        int Age;
        public Person(string name)
        {
            this.Name = name;
            Console.WriteLine("Person(string name)");
        }
        public Person(string name, int age) : this(name)
        {
            this.Age = age;
            Console.WriteLine("Person(string name, int age)");
        }
        public void Display()
        {
            Console.WriteLine(Name);
        }
    }
    class Employee : Person
    {
        string Company;
        public Employee(string name, int age, string company) : base(name, age)
        {
            this.Company = company;
            Console.WriteLine("Employee(string name, int age, string company)");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee tom = new Employee("Tom", 22, "Microsoft");

            Console.ReadLine();
        }
    }
}
