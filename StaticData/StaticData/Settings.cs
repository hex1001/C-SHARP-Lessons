using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StaticData
{
    class Settings
    {
        public static int x = 1;
        public static int y = 2;
        public static (int, int) getXY() 
        { 
            return (x, y);
        }
    }
}
