using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwriteOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Account a1 = new Account(45000);
            //    Account a2 = new Account(20000);
            //    Account a3 = a1 + a2;
            User u1 = new User(22, "user1", "rfvbgt");
            User u2 = new User(202, "user2", "qazxsw");
            Console.WriteLine(u1 > u2);
            Console.WriteLine(u1 < u2);
            UserSocial userSocial1 = new UserSocial(41, "sc1", "wqasde", "Weiken", 41);
            UserSocial userSocial2 = new UserSocial(81, "sc2", "123456", "Gorge", 56);
            Console.WriteLine(userSocial1 > userSocial2);
            Console.WriteLine(userSocial1 < userSocial2);
        }
    }

    class Account
    {
        public int balance;

        public Account(int balance)
        {
            this.balance = balance;
        }

        public static Account operator +(Account a1, Account a2) { 
            return new Account(a1.balance + a2.balance);
        } 
        public static Account operator -(Account a1, Account a2) { 
            return new Account(a1.balance - a2.balance);
        }

    }
}
