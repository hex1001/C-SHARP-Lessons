using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 40;
            //int b = 25;

            //Console.WriteLine($"{a} + {b} = {a + b}");
            //Console.WriteLine($"{a} - {b} = {a - b}");
            //Console.WriteLine($"{a} * {b} = {a * b}");
            //Console.WriteLine($"{a} / {b} = {a / b}");
            //Console.WriteLine($"7f / 3f = {7f / 3f}");
            //Console.WriteLine($"7.0 / 3.0 = {7.0 / 3.0}");
            //Console.WriteLine($"7m / 3m = {7m / 3m}");
            //Console.WriteLine($"{a} % {b} = {a % b}");

            //a++;
            //Console.WriteLine("a = " + a);
            //b--;
            //Console.WriteLine("b = " + b);
            float a = 14.0f;
            float b = 4.2f;
            Console.WriteLine($"{a} + {b} = {a + b}");
            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.WriteLine($"{a} * {b} = {a * b}");
            Console.WriteLine($"{a} / {b} = {a / b}");

            double d = (((25.0 / 20.0 - 15.0) * 2.0) - 24.0 + 15.0 / 5.0);
            
            Console.WriteLine(d);
        }
    }
}
