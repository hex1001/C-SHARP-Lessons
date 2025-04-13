using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person();
            //person.Age = 10;
            //Console.WriteLine(person.Age);
            Console.WriteLine("**********************************");
            User user = new User(15, "master", "qwert123");
            Console.WriteLine(user.Login);
            //Console.WriteLine(user);
            user.Login = "master2";
            Console.WriteLine("**********************************");
            Console.WriteLine(user.Login);
            //Console.WriteLine(user);
            Console.WriteLine("**********************************");

        }
    }
}
