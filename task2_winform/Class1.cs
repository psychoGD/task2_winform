using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2_winform
{
    [Serializable]
    public class User
    {
        public User(List<string> note, string username, string password)
        {
            this.note = note;
            Username = username;
            Password = password;
        }

        public List<string> note { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

    }
}
