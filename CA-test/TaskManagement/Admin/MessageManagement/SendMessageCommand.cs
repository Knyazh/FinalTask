using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Common.Commands;
using TaskManagement.Contants;
using TaskManagement.Database;
using TaskManagement.Database.Models;
using TaskManagement.Database.Repositories;
using TaskManagement.Jsons;
using TaskManagement.Services;

namespace TaskManagement.Admin.MessageManagement
{
    public class SendMessageCommand : ICommandHandler
    {
        public void Handle()
        {
            UserRepository userRepository = new UserRepository();
            MessageRepository messageRepository = new MessageRepository();

            string receiverEmail = Console.ReadLine()!;
            User receiver = userRepository.GetUserOrDefaultByEmail(receiverEmail);

            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.CONTENT_AZ));
            string contentaz = Console.ReadLine()!;

            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.CONTENT_RU));
            string contentru = Console.ReadLine()!;

            Console.WriteLine(LocalizationService.GetTranslation(TranslationKey.CONTENT_EN));
            string contenten = Console.ReadLine()!; 

            if (receiver == null)
            {
                Console.WriteLine("User not found");
                return;
            }

            Message message = new Message(contentaz, contentru,contenten, UserService.CurrentUser, receiver);
            messageRepository.Insert(message);
            Json.SerializeMessageToFile();
        }
    }
}
