using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022_NullValue
{
    class User
    {
        public Phone Phone { get; set; }
    }

    class Phone
    {
        public Company Company { get; set; }
    }

    class Company
    {
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            object x = null;
            string s = null;

            object y = x ?? 100; // y == 100

            object z = 200;
            object t = z ?? 44; // t == 200

            User user = new User();
            string companyName = user?.Phone?.Company?.Name;
            Console.WriteLine(companyName);

            Console.ReadLine();
        }
    }
}
