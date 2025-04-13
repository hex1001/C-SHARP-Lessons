using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace AnanymousMethodes

{
    class User : ICloneable
    {
        private int id;
        public delegate void Log(string msg);

        private Log log;

        public void Register(Log log)
        {
            this.log += log;
        }

        public int Id { 
            get { return id; } 
            set {
                log($"Изменено имя у пользователя ID: {id} из \"{id}\" на \"{value}\"");
                id = value; 
            } 
        }
        private string login;
        public string Login { 
            get { return login; } 
            
            set { 
                log($"Изменено имя у пользователя ID: {id} из \"{login}\" на \"{value}\"");
                login = value;
            } 
        }
        private string password;
        public string Password { 
            get {return password; } 
            set {password = value;
                log($"Изменено логин у пользователя ID: {id} из \"{password}\" на \"{value}\"");
            } 
        }
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
            //log($"Создан пользователь по умолчанию с помощью конструктора");
        }
        public override string ToString()
        {
            log("Был вызван метод ToString() для преобразования объекта в строку.");
            return $"id:{this.id}\nlogin:{this.login}\npassword:{this.password}";
        }
        
        public virtual void PrintToConsole()
        {
            log("Был вызван метод PrintToConsole()");
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
        public virtual void PrintUser() {; }

        public void AddToLog(string msg)
        {
            Console.WriteLine("Добавляем в лог: " + msg);

        }

        public virtual bool Equals(object obj)
        {
            User u;
            if (obj is User) u = (User)obj;
            else return false;
            return this.id == u.id;
        }

        public virtual object Clone()
        {
            log("Был вызван метод Clone()");
            return new User(id, login, password);
        }
    }
}
