using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Admin.BlogManagement;
using TaskManagement.Admin.ShowUser;
using TaskManagement.Admin.UserManagement;
using TaskManagement.Common;
using TaskManagement.Database;
using TaskManagement.Infrastructure;

namespace TaskManagement.Admin
{
    public class AdminDashboard : IDashboard
    {
        public void Introduction()
        {
            Console.WriteLine("Hello dear admin");

            Console.WriteLine("Aviable commands");
            Console.WriteLine("/show-users");
            Console.WriteLine("/show-user-by-email");
            Console.WriteLine("/show-user-by-id");
            Console.WriteLine("/add-user");
            Console.WriteLine("/approve-blog");
            Console.WriteLine("/logout");
            while (true)
            {
                string command = Console.ReadLine()!;

                switch (command)
                {
                    case "/show-users":
                        CommandRouter.Route<ShowUsersCommand>();
                        break;
                    case "/approve-blog":
                        CommandRouter.Route<ApproveBlogCommand>();
                        break;
                    case "/show-user-by-email":
                        CommandRouter.Route<ShowUserByEmailCommand>();
                        break;
                    case "/show-user-by-id":
                        CommandRouter.Route<ShowUserByIdCommand>();
                        break;
                    case "/add-user":
                        CommandRouter.Route<AddUserCommand>();
                        break;
                    case "/logout":
                        Console.WriteLine("Bye-bye");
                        return;
                    default:
                        Console.WriteLine("Invalid command, pls try again");
                        break;
                }
            }
        }
    }
}
