using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019_Static
{
    class Account
    {
        public static decimal bonus = 100;
        public decimal totalSum;

        public Account(decimal sum)
        {
            totalSum = sum + bonus;
        }
    }

    class User
    {
        private static int counter = 0;

        static User()
        {
            Console.WriteLine("First user created");
        }
        public User()
        {
            Console.WriteLine($"{counter} user created");
            counter++;
        }

        public static void DisplayCounter()
        {
            Console.WriteLine($"Count = {counter}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Account.bonus);
            Account.bonus += 200;

            Account account1 = new Account(150);
            Console.WriteLine(account1.totalSum); // 450

            Account account2 = new Account(1000);
            Console.WriteLine(account2.totalSum); // 1300

            User user1 = new User();
            User user2 = new User();
            User user3 = new User();
            User user4 = new User();
            User user5 = new User();

            User.DisplayCounter();

            Console.ReadLine();
        }
    }
}
