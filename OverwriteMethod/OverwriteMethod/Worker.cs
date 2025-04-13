using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwriteMethod
{
    class Worker : Person
    {
        private int salary;
        public Worker(string name, int age, int salary) : base(name, age)
        {
            this.salary = salary;
        }

        public override string GetTexInfo()
        {
            return base.GetTexInfo() + "; Зарплата: " + salary;
        }

    }
}
