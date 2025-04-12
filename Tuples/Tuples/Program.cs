using System;
using System.Collections.Generic;
//using System.Valu;
using System.Text;

namespace Tuples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var t1 = (20, 30, "test");
            Console.WriteLine(t1.Item1);
            Console.WriteLine(t1.Item2);
            Console.WriteLine(t1.Item3);

            var t2 = (name: "Alex", age: 41);
            Console.WriteLine(t2.name);
            Console.WriteLine(t2.age);
            
            (string, int) info = ("Testjon", 123);
            Console.WriteLine(info.Item1);
            Console.WriteLine(info.Item2);
            Console.WriteLine("*******************************");
            var person = (name:"Abu Umar", age: 41, city : "Navoi city");
            Console.WriteLine(person.name);
            Console.WriteLine(person.age);
            Console.WriteLine(person.city);

        }
    }
}
