using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManager
{
    class User
    {
        string Name { get; set; }

        public User(string Username)
        {
            this.Name = Username;
        }

        public User()
        {

        }

        public void SetName(string user_name)
        {
            this.Name = user_name;
        }

        public string getName()
        {
            return this.Name;
        }

    }

    class Faculty
    {

    }
}
