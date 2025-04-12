using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerations
{
    class Program
    {
        static void Main(string[] args)
        {
            Move.StartMove(Move.SOUTH);
            Move.StartMove(Move.NORTH);
            Move.StartMove(Move.WEST);
        }
    }

    static class Move
    {
        public static int NORTH = 1;
        public static int SOUTH = 2;
        public static int WEST = 3;
        public static int EAST = 4;

        public static void StartMove(int d)
        {
            if (d == NORTH) { Console.WriteLine("Движемся на Север"); }
            else if (d == SOUTH) { Console.WriteLine("Движемся на Юг"); }
            else if (d == WEST) { Console.WriteLine("Движемся на Запад"); }
            else if (d == EAST) { Console.WriteLine("Движемся на Восток"); }
        }
    }
}
