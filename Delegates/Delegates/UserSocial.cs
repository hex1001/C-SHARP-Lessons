using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
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
            base.PrintUser();
            Console.WriteLine(this.ToString());
        }
        public override bool Equals(object obj)
        {
            UserSocial user;
            if (obj is UserSocial) user = (UserSocial)obj;
            else return false;
            return this.Id == user.Id;
        }

        public override object Clone()
        {            
            return new UserSocial(base.Id, base.Login, base.Password, name, age);
        }

        public override string ToString()
        {
            return base.ToString() + $"; Имя: {name}; Возраст: {age}";
        }
    }
}
