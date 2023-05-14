using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TaskManagement.Database.Models.Common;

namespace TaskManagement.Database.Models
{
    public class Message : BaseEntity<int>
    {
        public static int IdCounter { get; private set; }

        public string Content_AZ { get; set; }
        public string Content_RU { get; set; }
        public string Content_EN { get; set; }
        public User Sender { get; set; }
        public User Receiver { get; set; }

        public Message(string contentaz, string contentru, string contenten, User sender, User receiver)
        {
            Id = ++IdCounter;
            Content_AZ = contentaz;
            Content_RU = contentru;
            Content_EN = contenten;
            Sender = sender;
            Receiver = receiver;
            CreatedAt = DateTime.Now;
        }
    }
}
