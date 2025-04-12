using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Access
{
    class Person
    {
        public string name;
        protected string city;
        private int age;

        private Person(string name, string city, int age) {
            this.name = name;
            this.city = city;
            this.age = age;
        }
        public Person():this("Default name", "Default city", 18) { 
        }

        public void SetAge(int age)
        {
            this.age = age;
        }
        public bool checkAge(int age) { return age > 18; }
        public int getAge() { return age; }
    }
}
