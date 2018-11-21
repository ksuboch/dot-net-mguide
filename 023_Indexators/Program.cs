using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023_Indexators
{
    class Person
    {
        public string Name { get; set; }
    }
    class People
    {
        Person[] data;
        public People()
        {
            data = new Person[5];
        }
        public Person this[int index]
        {
            get => data[index];
            set => data[index] = value;
        }
    }
    class User
    {
        string name;
        string email;
        string phone;

        public string this[string proname]
        {
            get
            {
                switch (proname)
                {
                    case "name": return "Mr/Ms. " + name;
                    case "email": return email;
                    case "phone": return phone;
                    default: return null;
                }
            }
            set
            {
                switch (proname)
                {
                    case "name":
                        name = value;
                        break;
                    case "email":
                        email = value;
                        break;
                    case "phone":
                        phone = value;
                        break;
                }
            }
        }
    }
    class Matrix
    {
        private int[,] numbers = new int[,] { { 1, 2, 3 }, { 2, 3, 6 }, { 3, 4, 8 } };
        public int this[int i, int j]
        {
            get => numbers[i, j];
            set => numbers[i, j] = value;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            People people = new People();
            people[0] = new Person { Name = "Tom" };
            people[1] = new Person { Name = "Bob" };

            Person tom = people[0];
            Console.WriteLine(tom?.Name);

            User jerry = new User();
            jerry["name"] = "Jerry";
            jerry["email"] = "Jerry@email.com";

            Console.WriteLine(jerry["name"]);

            Matrix m = new Matrix();
            Console.WriteLine(m[0, 0]);
            m[0, 0] = 111;
            Console.WriteLine(m[0, 0]);

            Console.ReadLine();
        }
    }
}
