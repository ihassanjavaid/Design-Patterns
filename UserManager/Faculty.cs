namespace UserManager
{
    class Faculty : IUser
    {
        public void display()
        {
            System.Console.WriteLine("Faculty");
        }
    }

    class Admin : IUser
    {
        public void display()
        {
            System.Console.WriteLine("Admin");
        }
    }
}
