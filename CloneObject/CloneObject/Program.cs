using System;
namespace CloneObject
{
    class Program
    {
        private static void Main(string[] args)
        {
            //Point p1 = new Point(5, 7);
            //Console.WriteLine(p1);
            ////Console.WriteLine(p2);
            //Point p2 = (Point)p1.Clone();
            //Console.WriteLine(p2);
            //p1.x = 25;

            ////p2 = new Point(54, 17);
            //p2.x = 7;
            //Console.WriteLine(p1);
            //Console.WriteLine(p2);
            UserSocial u1 = new UserSocial(14, "test", "test", "Test", 29);
            WebMaster w1 = new WebMaster(25, "testW", "west", "west.com");
            UserSocial u2 = (UserSocial)u1.Clone();
            WebMaster w2 = (WebMaster)w1.Clone();
            Console.WriteLine(u1);
            Console.WriteLine("************************************");
            Console.WriteLine(u2);
            Console.WriteLine("************************************");
            Console.WriteLine(w1);
            Console.WriteLine("************************************");
            Console.WriteLine(w2);
            u2.Login = "Tset";
            w2.Login = "West25";
            Console.WriteLine(u1);
            Console.WriteLine("************************************");
            Console.WriteLine(u2);
            Console.WriteLine("************************************");
            Console.WriteLine(w1);
            Console.WriteLine("************************************");
            Console.WriteLine(w2);


        }
    }
}