using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class UserOld
    {
        public delegate void Log(string msg);
        private event Log realHandler;
        public event Log handler
        {
            add
            {
                realHandler += value;
                Console.WriteLine("Добавлен обработчик");
            }
            remove
            {
                realHandler -= value;
                Console.WriteLine("Удалён обработчик");
            }
        }   

        private int id;

        public UserOld(int id) {
            this.id = id;
        }

        public void login()
        {
           if(realHandler != null)  realHandler($"Пользователь {id} совершил вход");
        }
        public void logout()
        {
            realHandler?.Invoke($"Пользователь {id} совершил выход");
        }


    }
}
