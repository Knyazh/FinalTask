using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Common.Commands;
using TaskManagement.Contants;
using TaskManagement.Database;
using TaskManagement.Database.Models;
using TaskManagement.Database.Repositories;
using TaskManagement.Jsons;
using TaskManagement.Services;

namespace TaskManagement.Client.Commands
{
    public class AddBlogCommand : ICommandHandler
    {
        public void Handle()
        {
            BlogRepository blogRepository = new BlogRepository();

            //Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.ADD_TITLE_AZ));
            Console.WriteLine("Title elave et");
            string titleaz = Console.ReadLine()!;
            //Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.ADD_TITLE_RU));          //buralarda null exception verirdi basa dusmedm
            Console.WriteLine("Dabovit title");                                                         //ona gore bele elnen yazdm
            string titleru = Console.ReadLine()!;
            //Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.ADD_TITLE_EN));
            Console.WriteLine("Enter title");
            string titleen = Console.ReadLine()!;


            //Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.CONTENT_AZ));
            Console.WriteLine("Cotnetn elave et");
            string contentaz = Console.ReadLine()!;
            //Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.CONTENT_RU));
            Console.WriteLine("Dabovit contenta");
            string contentru = Console.ReadLine()!;
            //Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.CONTENT_EN));
            Console.WriteLine("Add content");
            string contenten = Console.ReadLine()!;

            Blog blog = new Blog(titleaz, titleru,titleen, contentaz, contentru, contenten, UserService.CurrentUser, BlogStatus.Created);
            blogRepository.Insert(blog);
            Console.WriteLine($"Your blog successfully added blog title: {blog.Title_AZ} content:{blog.Content_AZ} code:{blog.Code}");
            Json.SerializeBlogToFile();
        }
    }
}
