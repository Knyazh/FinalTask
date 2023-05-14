using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Contants;
using TaskManagement.Database.Models.Common;
using static TaskManagement.Client.Commands.AddCommentToBlog;

namespace TaskManagement.Database.Models
{
    public class Blog : BaseEntity<decimal>
    {
        public static int IdCounter { get; private set; }

        public string Title_AZ  { get; set; }
        public string Title_RU { get; set; }
        public string Title_EN { get; set; }
        public string Content_AZ { get; set; }
        public string Content_RU { get; set; }
        public string Content_EN { get; set; }
        public User Owner { get; set; }

        public BlogStatus Status { get; set; }
        public string Code { get; private set; }
        public List<Comment> Comments { get; set; }


        public Blog(string titleaz, string titleru, string titleen, string contentaz, string contentru, string contenten, User owner, BlogStatus status)
        {
            Id = ++IdCounter;
            Title_AZ = titleaz;
            Title_RU = titleru;
            Title_EN = titleen;
            Content_AZ = contentaz;
            Content_RU = contentru;
            Content_EN = contenten;
            Owner = owner;
            CreatedAt = DateTime.Now;
            Status = status;
            Code = GenerateUniqueCode();
            Comments = new List<Comment>();


        }
        private string GenerateUniqueCode()
        {
            Random random = new Random();
            string code = "BL" + random.Next(10000, 99999);
            return code;
        }
    }
}
