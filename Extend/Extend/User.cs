using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Extend

{
    class User
    {
        private int id;
        public int Id { get { return id; } set {id = value; } }
        private string login;
        public string Login { get { return login; } set { login = value; } }
        private string password;
        private string Password { get {return password; } set {password = value; } }
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
