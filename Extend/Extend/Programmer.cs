using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extend
{
    class Programmer : Person
    {
        private int exp;
        public Programmer(string name, int age, int exp) : base(name, age)
        {
            this.exp = exp;   
        }
    }
}
