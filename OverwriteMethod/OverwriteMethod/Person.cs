using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwriteMethod
{
    class Person
    {
        private string name;
        private int age;

        public Person(string name, int age) { 
            this.name = name;   
            this.age = age;
        }

        public string GetName() { return name; }
        public int GetAge() { return age; }
        public void SetAge(int age) { this.age = age; }
        public void SetName(string name) { this.name = name; }
        public virtual string GetTexInfo()
        {
            return $"Имя: {name}; Возраст: {age}";
        }
    }
}
