using System;

namespace _016_RefTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            State state1 = new State();
            State state2 = new State();
            state2.x = 1;
            state2.y = 2;
            state1 = state2; // state1 is copy of state2
            state2.x = 5;
            Console.WriteLine(state1.x); // 1
            Console.WriteLine(state2.x); // 5

            Country country1 = new Country();
            Country country2 = new Country();
            country2.x = 1;
            country2.y = 4;
            country1 = country2; // country1 and country2 ref to the same object
            country2.x = 7;

            Console.WriteLine(country1.x); // 7
            Console.WriteLine(country2.x); // 7

            state2.country = new Country();
            state2.country.x = 5;
            state1 = state2; // state1.country and state2.country ref to the same object
            state2.country.x = 8;

            Console.WriteLine(state1.country.x); // 8
            Console.WriteLine(state2.country.x); // 8

            Person p = new Person { name = "Tom", age = 23 };
            ChangePerson(p);

            Console.WriteLine(p.name); // Alice
            Console.WriteLine(p.age); // 23

            ChangePerson(ref p);

            Console.WriteLine(p.name); // Bill
            Console.WriteLine(p.age); // 45

            Console.ReadLine();
        }

        static void ChangePerson(Person person)
        {
            person.name = "Alice";
            person = new Person { name = "Bill", age = 45 };
            Console.WriteLine(person.name); // Bill
        }

        static void ChangePerson(ref Person person)
        {
            person.name = "Alice";
            person = new Person { name = "Bill", age = 45 };
        }
    }
}
