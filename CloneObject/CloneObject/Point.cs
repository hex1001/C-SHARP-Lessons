using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneObject
{
    class Point : ICloneable
    {
        public int x { get; set; }
        public int y { get; set; }

        public Point(int x, int y)
        {
            this.x = x;     
            this.y = y;
        }

        public override string ToString() {
            return $"Точка c координатами ({x}; {y})";
        }

        public override bool Equals(object obj)
        {
            Point p;
;           if(obj is Point) p = (Point)obj;
            else return false;    
            return x == p.x && y == p.y;
        }

        public void Test(Point p)
        {
            p.x = 12;
            p.y = 15;
        }

        public void Test2(int x)
        {
            x = 25;
        }

        public object Clone()
        {
            int x = this.x + 10;
            int y = this.y + 10;
            return new Point(x, y);
        }
    }
}
