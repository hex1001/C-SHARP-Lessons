using System;

namespace Lambda
{
    class Program
    {
        private delegate void Message(string msg);
        private delegate void Test();
        private delegate bool IsLess(int a, int b);
        private delegate float Add(float a, float b);
        private static void Main(string[] args)
        {
            //Message message = (msg) => { Console.WriteLine(msg); };
            //message("Hello");

            //Test t = () => { Console.WriteLine("Test"); };
            //t();

            //PrintResult(10, 20, (a, b) => a < b);
            //PrintResult(100, 20, (a, b) => a < b);
            Add sum = (a, b) =>  a + b ;
            float res = sum(8.7f, 892f);
            Console.WriteLine(res);

        }

        private static void PrintResult(int a, int b, IsLess less)
        {
            if (less(a, b)) Console.WriteLine($"{a} менше, чем {b}");
            else Console.WriteLine($"{a} больше, либо равен {b}");
        }
    }
}