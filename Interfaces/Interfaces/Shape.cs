﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    abstract class Shape : IDrawShape
    {
        public int x;
        public int y;

        public Shape(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        abstract public void Draw();

        

    }
}
