using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwriteMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person per = new Person("Alex", 48);
            //Worker worker = new Worker("Nodir", 35, 36000);
            //Programmer pr = new Programmer("Mickael", 28, 7);
            //Console.WriteLine(per.GetTexInfo());
            //Console.WriteLine("******************");
            //Console.WriteLine(worker.GetTexInfo());
            //Console.WriteLine("******************");
            //Console.WriteLine(pr.GetTexInfo());
            User user = new User(14, "Simple", "s$ede$");
            user.PrintToConsole();
            Console.WriteLine("\n****************************************");
            UserSocial userSocial = new UserSocial(15, "Nikolas", "nik321", "Nikolas", 27);
            userSocial.PrintToConsole();
            Console.WriteLine("\n*******************************************");
            WebMaster web = new WebMaster(16, "sysadmin", "sys#ed45", "test.com");
            web.PrintToConsole();
            Console.WriteLine("\n*******************************************");

        }
    }
}
