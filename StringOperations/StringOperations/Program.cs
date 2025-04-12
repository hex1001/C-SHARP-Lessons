using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввведите 1-ю строку");
            string str1 = Console.ReadLine();
            Console.WriteLine("Ввведите 2-ю строку");
            string str2 = Console.ReadLine();
            string str3 = str1 + str2;

            Console.WriteLine(str3);
        }
    }
}
