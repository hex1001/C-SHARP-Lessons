using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class UserOld
    {
        private int id;
        public delegate void Log(string msg);

        private Log log;

        public UserOld(int id) {
            this.id = id;
        }
        public void Register(Log log)
        {
            this.log += log;
        }

        public void login()
        {
            log($"Ползователь {id} совершил вход");
        }
        public void logout()
        {
            log($"Ползователь {id} совершил выход");
        }


    }
}
