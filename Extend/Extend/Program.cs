using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extend
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person p = new Person("John", 18);
            //Programmer pr = new Programmer("Alex", 25, 5);
            //Worker wr = new Worker("Bill", 35, 25000);

            //Console.WriteLine(p.GetTexInfo());
            //Console.WriteLine(pr.GetTexInfo());
            //Console.WriteLine(wr.GetTexInfo());
            UserSocial userSocial = new UserSocial(15, "wiki", "dcxsw", "Nurik", 25);
            Console.WriteLine(userSocial.Name);
            Console.WriteLine("***************");
            WebMaster web = new WebMaster(15, "moderator", "mod123", "google.com");
            Console.WriteLine(web.Url);
            Console.WriteLine("***************");

        }
    }
}
