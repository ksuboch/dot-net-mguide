using System;

namespace _017_Properties
{
    class Person
    {
        private string name;
        private int age;

        public int Age
        {
            get => age;
            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Age must be larger then 17");
                }
                else
                {
                    age = value;
                }
            }
        }

        public string Name { get => name; set => name = value; }
    }
}
