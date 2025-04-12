using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace OOP
{
    class User
    {
        public int id;
        public string login;
        public string password;
        public static int count = 0;
        public User(int id, string login, string password)
        {
            this.id = id;
            this.login = login; 
            this.password = password;
            count = count + id;
            count++;
        }
        public User() : this(count, $"Noname{count}", $"Unknown{count}") { 
        }
        public override string ToString()
        {
            return $"id:{this.id}\nlogin:{this.login}\npassword:{this.password}";
        }
    }
}
