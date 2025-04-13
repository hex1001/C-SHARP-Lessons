using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Weapon : Item
    {
        private int damage;

        public Weapon(string name, float weight, int damage) : base(name, weight)
        {
            this.damage = damage;
        }
        public override void Use()
        {
            Console.WriteLine("Наносим противнику урон " + damage);
        }
    }
}
