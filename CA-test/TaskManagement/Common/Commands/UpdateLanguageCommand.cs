using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Contants;
using TaskManagement.Services;

namespace TaskManagement.Common.Commands
{
    public class UpdateLanguageCommand : ICommandHandler
    {
        public void Handle()
        {
            while (true)
            {

                Console.WriteLine("Aviable languages");
                Console.WriteLine();
                Console.WriteLine("English");
                Console.WriteLine("Russian");
                Console.WriteLine("Azerbaijani");
                Console.Write("Enter language:");
                string language = Console.ReadLine()!;

                if (language == "English")
                {
                    LocalizationService.CurrentCulture = SupportedCulture.EN;
                    return;
                }
                else if (language == "Russian")
                {
                    LocalizationService.CurrentCulture = SupportedCulture.RU;
                    return;
                }
                else if (language == "Azerbaijani")
                {
                    LocalizationService.CurrentCulture = SupportedCulture.AZ;
                    return;
                }
                else
                {
                    Console.WriteLine("Language not found");
                    Console.WriteLine();
                }
               
            }


        }
    }
}
