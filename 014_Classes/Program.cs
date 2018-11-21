using System;

namespace _014_Classes
{
    class Person
    {
        public string name;
        public int age;

        public Person() : this("Unknown")
        {

        }
        public Person(string name) : this(name, 18)
        {

        }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Name: {name} Age: {age}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person tom = new Person();
            tom.GetInfo();

            tom.name = "Tom";
            tom.age = 34;
            tom.GetInfo();

            Person bob = new Person("Bob");
            Person sam = new Person("Sam", 25);

            bob.GetInfo();
            sam.GetInfo();

            Person jerry = new Person { name = "Jerry", age = 31 };
            jerry.GetInfo();

            Console.ReadLine();
        }
    }
}
