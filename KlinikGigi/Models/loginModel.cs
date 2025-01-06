using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlinikGigi
{
    public class loginModel
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public loginModel(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
