using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Magic

{
    abstract class User : ILog
    {
        private int id;
        public int Id { get { return id; } set {id = value; } }
        private string login;
        public string Login { 
            get { return login; } 
            
            set { 
                AddToLog($"Изменено имя у пользователя ID: {id} из \"{login}\" на \"{value}\"");
                login = value;
            } 
        }
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
        
        public virtual void PrintToConsole()
        {
            Console.Write($"ID: {id}; Login: {login}; Password: {password}");
        }

        public static bool operator >(User u1, User u2)
        {
            return u1.id > u2.id ;
        }
        public static bool operator <(User u1, User u2)
        {
            return u1.id < u2.id ;
        }
        abstract public void PrintUser();

        public void AddToLog(string msg)
        {
            Console.WriteLine("Добавляем в лог: " + msg);

        }

        abstract public override bool Equals(object obj);
       
    }
}
