using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Contants;
using TaskManagement.Database.Models;
using TaskManagement.Database.Repositories;

namespace TaskManagement.Common.Commands
{
    public class ShowBlogsWithCommentsCommand : ICommandHandler
    {
        private readonly BlogRepository _blogRepository;

        public ShowBlogsWithCommentsCommand(BlogRepository blogRepository)
        {
            _blogRepository= blogRepository;
        }

        
        public void Handle()
        {

            var approvedBlogs = _blogRepository.GetAll().Where(b => b.Status == BlogStatus.Approved);
            foreach (var blog in approvedBlogs)
            {
                Console.WriteLine($"[{blog.CreatedAt:dd.MM.yyyy}] [{blog.Code}] [{blog.Owner.Name} {blog.Owner.LastName}]");
                Console.WriteLine($"=== {blog.Title_AZ} ===");
                Console.WriteLine($"{blog.Content_AZ}\n");
                Console.WriteLine("Comments :");
                for (int i = 0; i < blog.Comments.Count; i++)
                {
                    var comment = blog.Comments[i];
                    Console.WriteLine($"[{blog.CreatedAt:dd.MM.yyyy}] [{blog.Code}] [{blog.Owner.Name} {blog.Owner.LastName}]");
                }
                Console.WriteLine();
            }
        }


    }
}
