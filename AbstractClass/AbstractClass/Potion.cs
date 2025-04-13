using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AbstractClass
{
    class Potion : Item
    {
        private int health;

        public Potion(string name, float weight, int health) : base(name, weight)
        {
            this.health = health;
        }
        public override void Use()
        {
            Console.WriteLine("Восстанавливаем здаровье на " + health);
        }
    }
}
