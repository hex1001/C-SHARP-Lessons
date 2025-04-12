using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cycles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    for (int i = 0; i < 10; i++) { 
            //        Console.WriteLine("Hello world!");
            //    }
            //    Console.WriteLine("Цикл завершён");
            //    for (int i = 0; i < 10; i++) {
            //        Console.WriteLine($"i = {i}");
            //    }
            //    for (int i = 0; i <= 10; i++)
            //    {
            //        Console.Write(i);
            //        if (i < 10) Console.Write(", ");
            //        else Console.WriteLine("\n---------------------------");

            //    }
            //    int a = 0;
            //    while (a < 10) { 
            //        Console.WriteLine(a);
            //        a++;
            //    }
            //    Console.WriteLine("-------------------------------------");
            //    a = 0;
            //    do { 
            //        Console.WriteLine(a);
            //        a++;
            //    } while (a < 10);
            //    Console.WriteLine("-------------------------------------");

            double res = 1;
            double a = 1;
            string str;
            while (true) {
                Console.WriteLine("Biror bir son kiriting yoki natijani ko'rish uchun\"result\" so'ini yozing\nchiqib ketish uchun \"exit\" yoki \"quit\" sozini yozing.");
                Console.WriteLine("Hozir esa son kiriting:");
                str = Console.ReadLine();
                if (str == "result") {
                    Console.WriteLine($"natija: {res}");
                    res = 1;
                } else if(str == "exit" || str == "quit") { 
                    break;
                } else {
                    a = Convert.ToDouble(str);
                    res *= a;
                }
                
            }

        
        }
    }
}
