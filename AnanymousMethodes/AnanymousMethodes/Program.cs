using System;
namespace AnanymousMethodes
{
    class Program
    {
        private delegate bool IsLess(int a, int b);
        private delegate void Handler();
        private static void Main(string[] args)
        {
            IsLess t1 = test;
            Console.WriteLine(t1(5, 7));

            IsLess t2 = delegate(int a, int b) {  return a < b; };
            Console.WriteLine(t1(5, 7));

            Handler h1 = delegate () { Console.WriteLine("Handler 1"); };
            h1();
            Handler h2 = delegate () { Console.WriteLine("Handler 2"); };
            h2();
            //Test t1 = Handler1;
            //t1();
            //Console.WriteLine("**********************************");
            //Test t2 = Handler2;
            //t2();
            //Console.WriteLine("**********************************");
            //t1 += Handler2;
            //t1();
            //Console.WriteLine("**********************************");
            //t1 -= Handler1;
            //t1();

        }

        static bool test(int a, int b)
        {
            return a < b;
        }

       


    }
}