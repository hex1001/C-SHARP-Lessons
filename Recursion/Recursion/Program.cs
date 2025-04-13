using System;

namespace Recursion
{


    class Program
    {
        private static void Main(string[] args)
        {
            //for (int i = 10; i > 0; --i)
            //{
            //    Console.WriteLine(i);
            //}
            //PrintNumbers(10);
            //Console.WriteLine(SumDigits(548548));
            Int64 n;
            string inpt;
            while (true) { 
                inpt = Console.ReadLine();

                if (inpt == "exit") break;
                else
                {
                    n = Convert.ToInt64(inpt);
                    if (n < 0) 
                        continue;
                    Console.WriteLine(Factorial(n));
                }
            }
        }

        static void PrintNumbers(int n) {
            Console.WriteLine(n);
            if (n > 1)  PrintNumbers(n - 1);
            
            
        }

        static int SumDigits(int n)
        {
            int sum = 0;
            if(n == 0) return 0;
            sum += n % 10;
            sum += SumDigits(n / 10);
            return sum;
        }
        static Int64 Factorial(Int64 n)
        {
            if(n == 0 || n == 1) return 1;            
            return n * Factorial(n - 1);
        }
    }
}