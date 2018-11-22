using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _025_ClassConversion
{
    class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }
        public void Display()
        {
            Console.WriteLine($"Person {Name}");
        }
    }
    class Employee : Person
    {
        public string Company { get; set; }
        public Employee(string name, string company) : base(name)
        {
            Company = company;
        }
    }
    class Client :Person
    {
        public string Bank { get; set; }
        public Client(string name, string bank) : base(name)
        {
            Bank = bank;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // upcasting
            Employee employee = new Employee("Tom", "Microsoft");
            Person person = employee;
            person.Display();

            Person person2 = new Client("Bob", "ContosoBank");
            person2.Display();

            // downcasting
            Employee employee2 = (Employee)person;
            Console.WriteLine(employee2.Company);

            // using as
            Person person3 = new Person("Jerry");
            Employee emp3 = person3 as Employee;
            if (emp3 == null)
            {
                Console.WriteLine("Casting error");
            }
            else
            {
                Console.WriteLine(emp3.Company);
            }

            // using try catch
            try
            {
                Employee emp4 = (Employee)person3;
                Console.WriteLine(emp4.Company);
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // using is
            if (person3 is Employee)
            {
                Employee emp5 = (Employee)person3;
                Console.WriteLine(emp5.Company);
            }
            else
            {
                Console.WriteLine("Casting error");
            }

            Console.ReadLine();
        }
    }
}
