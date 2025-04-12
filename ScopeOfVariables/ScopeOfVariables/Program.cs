using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScopeOfVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i = 5;
            //if (true) {
            //    int c  = 10;
            //    Console.WriteLine(i);
            //}

            //if (true) {
            //    int c = 20;
            //    Console.WriteLine(c);
            //}
            string str = "test";
            Console.WriteLine(str + "\n\n*****************************\n");
            for (int i = 0; i < 6; i++) { 
                int a = 324;
                Console.WriteLine($"{str}");
                Console.WriteLine($"{a}");

            }
            //Console.WriteLine($"{a}");

        }
    }
}
