using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Contants;
using TaskManagement.Database.Models;
using TaskManagement.Database.Repositories;

namespace TaskManagement.Services
{
    public class MessageService
    {
        private MessageRepository _messageRepository;

        public static SupportedCulture CurrentCulture { get; set; } = SupportedCulture.AZ;

        public static string GetTranslation(TranslationKey key)
        {
            Type translationConstantType = typeof(TranslationConstant);

            string fieldName = $"{key}_{CurrentCulture}";
            FieldInfo fieldInfo = translationConstantType.GetField(fieldName)!;

            return (string)fieldInfo.GetValue(null);
        }
        public MessageService()
        {
            _messageRepository = new MessageRepository();
        }

        public void SenApprovedMessage(Blog blog)
        {
            string approvedMessage = PrepareBlogMessage(MessageTemplate.BLOG_APPROVED_TEMPLATE_AZ, blog);
            SendMessage(approvedMessage, blog.Owner);
        }

        private void SendMessage(string approvedMessage, User owner)
        {
            throw new NotImplementedException();
        }

        public void SendRejectedMessage(Blog blog)
        {
            string rejectedMessage = PrepareBlogMessage(MessageTemplate.BLOG_REJECTED_TEMPLATE_AZ, blog);
            SendMessage(rejectedMessage, blog.Owner);
        }

        private string PrepareBlogMessage(string blogMessageTemplate, Blog blog)
        {
            return blogMessageTemplate
              .Replace(MessageTemplateKeyword.FIRST_NAME, blog.Owner.Name)
              .Replace(MessageTemplateKeyword.LAST_NAME, blog.Owner.LastName)
              .Replace(MessageTemplateKeyword.BLOG_TITLE, blog.Title_AZ);
        }

        public void SendMessage(string contentaz, string contentru, string contenten, User sender, User receiver)
        {
            Message messageRecord = new Message(contentaz,contentru,contenten, sender, receiver);
            _messageRepository.Insert(messageRecord);
        }

        /// <summary>
        /// Sender will be current logged user
        /// </summary>
        public void SendMessage(string contentaz, string contentru, string contenten, User receiver)
        {
            SendMessage(contentaz, contentru, contenten, UserService.CurrentUser, receiver);
        }
    }
}
