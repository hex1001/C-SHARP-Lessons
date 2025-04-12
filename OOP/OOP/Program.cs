using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person p = new Person("Mickael", "Moscow", 30);
            //Console.WriteLine(p.ToString());
            //Console.WriteLine("*********************************");
            //Person p2 = new Person();
            //Console.WriteLine(p2.ToString());
            Console.WriteLine("*********************************");
            User user = new User(1, "Nodir", "12345");
            Console.WriteLine(user.ToString());
            Console.WriteLine("*********************************");
            User user1 = new User();
            Console.WriteLine(user1.ToString());
            Console.WriteLine("*********************************");

        }
    }
}
