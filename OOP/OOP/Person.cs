using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP
{
    class Person
    {
        public string name;
        public string city;
        public int age;
        public Person(string name, string city, int age) {
            this.name = name;
            this.city = city;  
            this.age = age;
        }
        public Person(): this("Default name", "Default city", 18)
        {
            Console.WriteLine("Создан объект с поляим умолчание");
        }
        public override string ToString()
        {
            return $"{this.name}\n{this.city}\n{this.age}";
        }
    }
}
