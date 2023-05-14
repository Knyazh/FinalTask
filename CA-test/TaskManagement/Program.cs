using System;
using System.Collections;
using System.Reflection.Metadata;
using System.Text.Json;
using TaskManagement.Client.Commands;
using TaskManagement.Common.Commands;
using TaskManagement.Database;
using TaskManagement.Database.Models;
using TaskManagement.Database.Repositories;
using TaskManagement.Infrastructure;
using TaskManagement.Jsons;
using TaskManagement.Services;

namespace TaskManagement
{
    public class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Available commands");
                Console.WriteLine();
                Console.WriteLine("/register");
                Console.WriteLine("/login");
                Console.WriteLine("/update-language");
                Console.WriteLine("/show-blogs-with-comments");
                Console.WriteLine("/exit");

                string command = Console.ReadLine()!;
                switch (command)
                {
                    case "/register":
                        CommandRouter.Route<RegisterCommand>();
                        break;
                    case "/login":
                        CommandRouter.Route<LoginCommand>();
                        break;
                    case "/update-language":
                        CommandRouter.Route<UpdateLanguageCommand>();
                        break;
                    case "/show-blogs-with-comments":
                        CommandRouter.Route<ShowBlogsWithCommentsCommand>();
                        break;
                    case "/exit":
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
