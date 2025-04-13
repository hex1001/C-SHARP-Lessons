using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Test<X, Y>
    {
        private X data1;
        private Y data2;

        public Test(X data1, Y data2) { 
            this.data2 = data2;
            this.data1 = data1;
        }
        public X GetData1() { 
            return data1; 
        }
        public Y GetData2() { 
            return data2;
        }

        public void SetData1(X data1)
        {
            this.data1 = data1;
        }
        public void SetData2(Y data2)
        {
            this.data2 = data2;
        }

        public void print()
        {
            Console.WriteLine(data1);
            Console.WriteLine(data2);
        }

    }
}
