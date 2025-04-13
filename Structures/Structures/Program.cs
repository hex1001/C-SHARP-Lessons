using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            //QuestInfo qi1;
            //qi1.title = "Квест";
            //qi1.award = 300;
            //qi1.print();
            //Console.WriteLine("****************************");
            //QuestInfo qi2 = new QuestInfo { title = "Заголовок", award = 500 };
            //qi2.print();
            User user = new User { id = 15, login = "guest", password = "1" };
            user.print();


        }
    }
}
