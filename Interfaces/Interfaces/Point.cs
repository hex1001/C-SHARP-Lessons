using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Point : Shape
    {
        public Point(int x ,int y): base(x, y) { }
        public override void Draw()
        {
            Console.WriteLine($"Рисуем точку с координатами ({x}; {y})");
        }

    }
}
