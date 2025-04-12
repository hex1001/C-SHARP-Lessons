using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Access
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person();
            //Person.SetAge(1);
            //Console.WriteLine(person.GetAge());
            //Console.WriteLine("**************************");
            User user = new User(45, "Test", "ikmju");
            Console.WriteLine(user.GetLogin());
            Console.WriteLine("*******************************");


        }
        
    }
}
