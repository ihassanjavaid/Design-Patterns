using System;

namespace UserManager
{
    class EntryPoint
    {
        static void Main(string[] argv)
        {
            Console.WriteLine("Hello!");

            /*User user = new User("XYZ");
            //user.SetName("ABC");
            Console.WriteLine("Hello " + user.getName());
            Console.ReadKey();

            Faculty facultyUser = new Faculty();
            facultyUser.display();

            // Is-a Relationship

            User user1 = new User();

            user1 = new Faculty();*/

            
            IUser user;

            user = new Faculty();

            user = null;

            user = new Admin();

            Console.ReadKey();

        }
    }
}
