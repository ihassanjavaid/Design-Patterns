using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace UserManagerSingleton.Security
{
    public class User
    {

        public string userName { get; set; }

        private User()
        {
            Count++;
            Console.WriteLine("Instance " +Count+ " is created!");
        }

        private static User Instance;
        private static int Count = 0;

        public static User getInstance()
        {
            /*if (Instance != null)
                return Instance;

         
            Instance = new User();
            return Instance;*/

            /*if (Instance == null)
                Instance = new User();
            return Instance;*/

            return Instance ?? method();
        }

        private static User method() => Instance = new User();
    }
}
