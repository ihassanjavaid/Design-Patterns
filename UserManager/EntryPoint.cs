using System;

namespace UserManager
{
    class EntryPoint
    {
        static void Main(string[] argv)
        {
            Console.WriteLine("Hello!");

            User user = new User("XYZ");
            //user.SetName("ABC");
            Console.WriteLine("Hello " + user.getName());
            Console.ReadKey();

            Faculty facultyUser = new Faculty();
            facultyUser.display();

        }
    }
}
