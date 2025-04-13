using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permanent
{
    class MyMath
    {
        private static int count = 0;

        public const double PI = 3.14159265;
        public const double E = 2.71828183;
        public static double Add(double a, double b) { count++;   return a + b; }
        public static double Sub(double a, double b) { count++;   return a - b; }
        public static double Mult(double a, double b) { count++;  return a * b; }
        public static double Div(double a, double b) { count++;   return b != 0 ? a / b: 0; }
        public static int Get() { return count; }
    }
}
