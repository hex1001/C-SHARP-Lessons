using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwriteMethod
{
    class Programmer : Person
    {
        private int exp;
        public Programmer(string name, int age, int exp) : base(name, age)
        {
            this.exp = exp;   
        }
        public override string GetTexInfo()
        {
            return base.GetTexInfo() + "; Опыт: " + exp;
        }
    }
}
