using System;
using TaskManagement.Common;

namespace TaskManagement
{
    public class LanguageCommand : ICommandHandler
    {
        public void Handle()
        {
            Console.WriteLine("Please select a language:");
            Console.WriteLine("1. Azerbaijani");
            Console.WriteLine("2. Russian");
            Console.WriteLine("3. English");

            int choice = int.Parse(Console.ReadLine()!);

            string language;
            switch (choice)
            {
                case 1:
                    language = "Azerbaijani";
                    break;
                case 2:
                    language = "Russian";
                    break;
                case 3:
                    language = "English";
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again");
                    return;
            }

            Console.WriteLine($"Language preference set to {language}");
        }
    }
}
