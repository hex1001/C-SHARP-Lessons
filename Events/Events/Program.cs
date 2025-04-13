using System;

namespace Events
{

    class Program
    {
        private static void Main(string[] args)
        {
            //UserOld u = new UserOld(1);
            //u.handler += logging;
            //u.login();
            //u.logout();
            //u.handler -= logging;
            UserSocial u = new UserSocial(3, "sfsf0", "erer", "efefef", 52);
            u.Register(new UserSocial.Log(logging));
            u.Login = "Tehbest";
            Console.WriteLine(u);
            WebMaster w = new WebMaster(3, "lomju", "51478", "mail.com");
            w.Register(new WebMaster.Log(logging));
            Console.WriteLine(w);
        }

        private static void logging(string msg)
        {  
            Console.WriteLine(msg); 
        }
    }
}