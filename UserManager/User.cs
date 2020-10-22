using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManager
{

    interface IUser
    {
        void display();
    }

    public abstract class User : IUser
    {
        string name { get; set; }

        public User(string Username)
        {
            this.name = Username;
        }

        public User()
        {

        }

        public void setName(string user_name)
        {
            this.name = user_name;
        }

        public string getName()
        {
            return this.name;
        }

        public void display()
        {
            Console.WriteLine("Hello " + this.name);
        }

    }
}
