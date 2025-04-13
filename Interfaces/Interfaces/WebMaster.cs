using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
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
    }
}
