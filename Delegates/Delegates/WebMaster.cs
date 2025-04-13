using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Delegates
{
    class WebMaster : User
    {
        private string url;
        public string Url { get { return url; } set { url = value; } }

        public WebMaster(int id, string login, string password, string url) : base(id, login, password)
        {
            this.url = url;
        }

        public override void PrintToConsole()
        {
            base.PrintToConsole();
            Console.WriteLine($"; Url: {url}");
        }
        public override void PrintUser()
        {
            Console.WriteLine(this.ToString());
        }
        public override bool Equals(object obj)
        {
            WebMaster user;
            if (obj is WebMaster) user = (WebMaster)obj;
            else return false;
            return this.Id == user.Id;
        }

        public override object Clone()
        {
            return new WebMaster(Id, Login, Password, url);
        }
        public override string ToString()
        {
            return base.ToString() + $"; URL: {url}";
        }
    }
}
