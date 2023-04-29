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
            if (choice == 1)
            {
                language = "Azerbaijani";
            }
            else if (choice == 2)
            {
                language = "Russian";
            }
            else if (choice == 3)
            {
                language = "English";
            }
            else
            {
                Console.WriteLine("Invalid choice, please try again");
                return;
            }

            Console.WriteLine($"Language preference set to {language}");
        }
    }
}
