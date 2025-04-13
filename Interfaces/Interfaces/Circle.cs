using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Circle : Shape
    {
        public int radius;

        public Circle(int x, int y, int radius): base(x, y)
        {
            this.radius = radius;
        }

        public override void Draw()
        {
            Console.WriteLine($"Рисуем окуржность с центром ({x}; {y}) и радиусом {radius}");
        }
    }
}
