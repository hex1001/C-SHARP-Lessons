using System;
namespace Magic
{
    class Program
    {
        private static void Main(string[] args)
        {
            //Point p1 = new Point(30, 10);
            //Console.WriteLine(p1);
            //string s = "Наш объект: " + p1;
            //Console.WriteLine(s);
            //Point p2 = new Point(30, 10);
            //Console.WriteLine(p2 == p1);
            //Console.WriteLine(p1.Equals(p2));

            //p1.Test(p2);
            //Console.WriteLine(p2.Equals(p1));
            //Console.WriteLine(p2);
            //int x = 35;
            //p1.Test2(x);
            //Console.WriteLine(x);
            //Console.WriteLine(p1);
            //Console.WriteLine(p2);
            UserSocial u1 = new UserSocial(15, "bin", "Binary", "Bill", 65);
            UserSocial u2 = new UserSocial(15, "bin2", "Binary2", "Biki", 16);
            WebMaster w1 = new WebMaster(15, "niki", "naki2", "test.com");
            Console.WriteLine(u1.Equals(w1));
            Console.WriteLine(u1.Equals(u2));
           
        }
    }
}