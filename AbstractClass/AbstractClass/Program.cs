using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Weapon wp = new Weapon("Kiko", 45f, 500);
            UserSocial userSocial = new UserSocial(22, "tiko", "tiko123", "Lasetti", 15);
            WebMaster webMaster = new WebMaster(23, "damas", "damas123", "test.com");
            Console.WriteLine("******************************");
            userSocial.PrintUser();
            Console.WriteLine("******************************");
            webMaster.PrintUser();


        }
    }
}
