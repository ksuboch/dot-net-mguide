using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = "Tom";
            string personName = p.Name;

            Account a = new Account { sum = 50 };
            Console.WriteLine(a.ToString());

            Console.ReadLine();
        }
    }

    class Account
    {
        public int sum { get; set; }
    }
}
