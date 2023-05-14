using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Common.Commands;
using TaskManagement.Contants;
using TaskManagement.Database.Models;
using TaskManagement.Database.Repositories;

namespace TaskManagement.Client.Commands
{
    public class AddCommentToBlog : ICommandHandler
    {
        public void Handle()
        {
            Console.WriteLine("Enter the blog code:");
            string blogCode = Console.ReadLine();

            Blog blog = BlogRepository.GetByCode(blogCode);

            if (blog == null)
            {
                Console.WriteLine("Invalid blog code");
                return;
            }

            Console.WriteLine("Enter the comment text:");
            string commentText = Console.ReadLine();

            var comment = new Comment(commentText, blog.Owner);
            blog.Comments.Add(comment);

            Console.WriteLine("Comment added successfully");

            string message = $"{blogCode} blog code {comment.Owner.Name} {comment.Owner.LastName} tərəfindən comment əlavə olundu.";
            Console.WriteLine(message);
        }

        public class Comment
        {
            public string Text { get; set; }
            public User Owner { get; set; }

            public Comment(string text, User owner)
            {
                Text = text;
                Owner = owner;
            }
        }
    }
}



