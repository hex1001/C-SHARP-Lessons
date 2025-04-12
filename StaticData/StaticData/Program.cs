using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StaticData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person();
            //Console.WriteLine(Person.GetCount());
            //Console.WriteLine("******************************");
            //Person person2 = new Person();
            //Console.WriteLine(Person.GetCount());
            //Console.WriteLine("******************************");
            //Console.WriteLine(Settings.x);
            //Console.WriteLine(Settings.y);
            //Console.WriteLine(Settings.getXY());
            //Console.WriteLine("******************************");
            Console.WriteLine(MyMath.Add(23.5, 45.7));
            Console.WriteLine("Count : " + MyMath.Get());
            Console.WriteLine("******************************");
            Console.WriteLine(MyMath.Mult(23.5, 45.7));
            Console.WriteLine("Count : " + MyMath.Get());
            Console.WriteLine("******************************");
            Console.WriteLine(MyMath.Div(23.5, 45.7));
            Console.WriteLine("Count : " + MyMath.Get());
            Console.WriteLine("******************************");
            Console.WriteLine(MyMath.Sub(23.5, 45.7));
            Console.WriteLine("Count : " + MyMath.Get());
            Console.WriteLine("******************************");
        }
    }
}
