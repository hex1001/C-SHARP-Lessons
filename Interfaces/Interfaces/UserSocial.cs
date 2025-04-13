using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class UserSocial : User
    {
        private string name;
        private int age;
        public string Name {  get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }

        public UserSocial(int id, string login, string password,string name, int age) :base(id, login, password) { 
            this.name = name;
            this.age = age;
        }
        public override void PrintToConsole()
        {
            base.PrintToConsole();
            Console.WriteLine($"; Name: {name}; Age: {age}");
        }
        public override void PrintUser()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
