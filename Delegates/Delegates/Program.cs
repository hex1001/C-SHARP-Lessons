using System;

namespace Delegates
{
    class Program
    {
        delegate void Test();
        private static void Main(string[] args)
        {
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

            //UserOld u = new UserOld(1);
            //u.Register(new UserOld.Log(PrintMessage));
            //u.Register(new UserOld.Log(Log.AddToLog));
            //u.login();
            ////u.logout();
            ///
            UserSocial u = new UserSocial(3, "sfsf0", "erer", "efefef", 52);
            u.Register(new UserSocial.Log(PrintMessage));
            u.Login = "Tehbest";
            Console.WriteLine(u);
            WebMaster w = new WebMaster(3, "lomju", "51478", "mail.com");
            w.Register(new WebMaster.Log(PrintMessage));
            Console.WriteLine(w);

        }
        
        private static void Handler1()
        {
            Console.WriteLine("Handler 1");
        }
        private static void Handler2()
        {
            Console.WriteLine("Handler 2");
        }

        private static void PrintMessage(string msg) { 
            Console.WriteLine(msg);
        }

    }
}