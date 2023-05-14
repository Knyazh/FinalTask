using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Contants
{
    static class MessageTemplate
    {
        public const string BLOG_APPROVED_TEMPLATE_EN = "Dear {firstName} {lastName}, your blog {title} approved by admin.";
        public const string BLOG_APPROVED_TEMPLATE_AZ = "Eziz {firstName} {lastName}, Senin blog {title} Qebul olundu admin terefinden.";
        public const string BLOG_APPROVED_TEMPLATE_RU = "Daroqoya {firstName} {lastName}, tvoi blog {title} Tesdiqlenim .";

        public const string BLOG_REJECTED_TEMPLATE_EN = "Dear {firstName} {lastName}, your blog {title} rejected by admin.";
        public const string BLOG_REJECTED_TEMPLATE_AZ = "Eziz {firstName} {lastName}, senin blog {title} redd edildi by admin.";
        public const string BLOG_REJECTED_TEMPLATE_RU = "Daroqoya {firstName} {lastName}, tvoi blog {title} rejected by admin.";
    }
}
