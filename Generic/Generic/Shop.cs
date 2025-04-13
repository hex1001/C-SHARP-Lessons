using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Shop<T>
    {
        T[] values;
        public Shop(T[] values)
        {
            this.values = values;
        }
        public void PrintObject()
        {
            foreach (var item in values)
            {
                Console.WriteLine(item);
            }
        }
    }
}
