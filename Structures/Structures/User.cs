using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    struct User
    {
        public int id;
        public string login;
        public string password;

        public void print()
        {
            Console.WriteLine($"id={id}; логин={login}; password={password}");
        }
    }
}
