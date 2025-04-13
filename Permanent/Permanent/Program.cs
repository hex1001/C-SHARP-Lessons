using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permanent
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyClass myClass = new MyClass();
            //Console.WriteLine(myClass.x);
            //Console.WriteLine(myClass.y);
            //Console.WriteLine(myClass.ss.x);
            //Console.WriteLine(myClass.ss.y);
            //Console.WriteLine(MyClass.Z);
            Console.WriteLine(MyMath.PI);
            Console.WriteLine(MyMath.E);

        }
    }
    class MyClass
    {
        public readonly int x = 10;
        public readonly int y;
        public readonly MyStruct ss;

        public const int Z = 100;
        public MyClass()
        {
            x = 20;
            y = 15;
            ss.x = 55;
            ss.y = 77;
        }

        public void Change()
        {
            // x = 10;
        }
    }

    struct MyStruct{
        public int x;
        public int y;
    }

}

