using System;

namespace _015_Structs
{
    struct User
    {
        public string name;
        public int age;

        public User(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name} Age: {age}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            User tom;
            tom.name = "Tom";
            tom.age = 34;
            tom.DisplayInfo();

            User bob = new User();
            bob.DisplayInfo();

            User jerry = new User("Jerry", 18);
            jerry.DisplayInfo();

            User sam = new User { name = "Sam", age = 35 };
            sam.DisplayInfo();

            Console.ReadLine();
        }
    }
}
