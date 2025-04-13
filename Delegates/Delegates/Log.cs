using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Log
    {
        public static void AddToLog(string message)
        {
            Console.WriteLine("Добавляем запись в лог: " + message);
        }
    }
}
