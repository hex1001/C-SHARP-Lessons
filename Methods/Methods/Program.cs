using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //person p1 = new person("john", "london", 42);
            //console.writeline(p1.gettextinfo());
            User user = new User(5, "verde", "fre321");
            Console.WriteLine(user.GetLogin());
            Console.WriteLine("*************************");
            user.SetLogin("Nodir");
            Console.WriteLine(user.GetLogin());
        }
    }
}
