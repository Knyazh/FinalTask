using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Admin.ShowUser;
using TaskManagement.Admin.UserManagement;
using TaskManagement.Client.Commands;
using TaskManagement.Common;
using TaskManagement.Database.Models;
using TaskManagement.Infrastructure;
using TaskManagement.Services;

namespace TaskManagement.Client
{
    public class ClientDashboard : IDashboard
    {
        public void Introduction()
        {
            Console.WriteLine($"Hello! : {UserService.CurrentUser.Email} {UserService.CurrentUser.Name}");


            while (true)
            {
            Console.WriteLine("Aviable commands");
            Console.WriteLine("/add-blog");
            Console.WriteLine("/add-comment-to-blog");
            Console.WriteLine("/closeaccount");
            Console.WriteLine("/update-setting");
            Console.WriteLine("/show-messages");
            Console.WriteLine("/logout");
                string command = Console.ReadLine()!;

                switch (command)
                {
                    case "/add-blog":
                        CommandRouter.Route<AddBlogCommand>();
                        break;
                    case "/add-comment-to-blog":
                        CommandRouter.Route<AddCommentToBlog>();
                        break;
                    case "/closeaccount":
                        CommandRouter.Route<CloseAccountCommand>();
                        break;
                    case "/update-setting":
                        CommandRouter.Route<UpdateSettingsCommand>();
                        break;
                    case "/show-messages":
                        CommandRouter.Route<ShowMessagesCommand>();
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
