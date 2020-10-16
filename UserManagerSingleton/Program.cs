using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagerSingleton.Security;

namespace UserManagerSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            /*User user = new User();
            user.userName = "ABC";
            User user2 = new User();
            user2.userName = "XYZ";*/

            User user = User.getInstance();
            user.userName = "ABC";
            User user2 = User.getInstance();
            user2.userName = "MNO";
            User user3 = User.getInstance();
            user3.userName = "XYZ";

            Console.ReadKey();
        }
    }
}
