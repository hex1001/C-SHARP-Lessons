using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerations
{
    enum Operations
    {
        ADD,
        SUB,
        MULTIPLY
    }
    enum Direction
    {
        NORTH,
        SOUTH,
        WEST,
        EAST
}
    class Program
    {
        static void Main(string[] args)
        {
            //Move.StartMove(Direction.EAST);
            //Move.StartMove(Direction.NORTH);
            //Move.StartMove(Direction.WEST);
            Console.WriteLine(Calc(15, 15, Operations.ADD));
            Console.WriteLine(Calc(15, 15.5, Operations.SUB));
            Console.WriteLine(Calc(15, 105, Operations.MULTIPLY));
        }
        static double Calc(double a, double b, Operations op)
        {
            double res = 0;
            if (op == Operations.ADD) { res = a + b; }
            else if (op == Operations.SUB) { res = a - b; }
            else if (op == Operations.MULTIPLY) { res = a * b; }
            return res;
        }
    }

    static class Move
    {
        public static void StartMove(Direction d)
        {
            if (d == Direction.NORTH) { Console.WriteLine("Движемся на Север"); }
            else if (d == Direction.SOUTH) { Console.WriteLine("Движемся на Юг"); }
            else if (d == Direction.WEST) { Console.WriteLine("Движемся на Запад"); }
            else if (d == Direction.EAST) { Console.WriteLine("Движемся на Восток"); }
        }
    }
}
