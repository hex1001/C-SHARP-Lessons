using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Methods
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

        public string getTextInfo()
        {
            return $"Имя: {name};\nГород: {city};\nВозраст: {age} ";
        }
        public override string ToString()
        {
            return $"{this.name}\n{this.city}\n{this.age}";
        }

        public int GetAge() { 
            return age;
        }
        public string GetCity() { 
            return city;
        }

        public string GetName()
        {
            return name;
        }

        public void SetAge(int age) { 
            this.age=age;
        }
        public void SetCity(string city) { 
            this.city=city;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

    }
}
