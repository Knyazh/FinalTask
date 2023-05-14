using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using TaskManagement.Contants;
using TaskManagement.Database.Models;

namespace TaskManagement.Database
{
    public class DataContext
    {
        public static List<User> Users { get; set; } = new List<User>();
        public static List<Message> Messages { get; set; } = new List<Message>();
        public static List<Blog> Blogs { get; set; } = new List<Blog>();

      
       

       

        static DataContext()
        {
            AddUserSeeedings();
        }

        public DataContext()
        {
            AddUserSeeedings();
        }

        private static void AddUserSeeedings()
        {
            Users.Add(new User("Super", "Admin", "123321", "admin@gmail.com", new DateTime(2022, 01, 01),  UserRole.Admin));
            Users.Add(new User("Knyaz", "Heydarov", "123", "knyaz@code.edu.az", new DateTime(2023, 05, 13), UserRole.Member));
        }
    }
}
