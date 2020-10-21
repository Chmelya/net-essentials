using System;
using DataBaseLibrary;

namespace ExampleOfLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new ManagerDbUser();
            manager.UseDatabase(new Database());

            var user = new UserDbUser();
            user.UseDatabase(new Database());

            var admin = new AdminDbUser();
            admin.UseDatabase(new Database());

        }
    }
}
