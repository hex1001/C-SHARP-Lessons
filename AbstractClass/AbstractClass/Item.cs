using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    abstract  class Item
    {
        protected string name;
        protected float weight;

        public Item(string name, float weight)
        {
            this.name = name;
            this.weight = weight;
        }

        abstract public void Use();
    }
}
