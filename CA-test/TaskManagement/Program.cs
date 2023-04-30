using TaskManagement.Common;
using TaskManagement.Database;
using TaskManagement.Services;

namespace TaskManagement
{
    //Encapsulaiton

    public class Program
    {
        static void Main(string[] args)
        {
            var localizationService = new LocalizationService();

            localizationService.AddTranslation("az", "Email daxil edin", "Email daxil edin");
            localizationService.AddTranslation("ru", "Email daxil edin", "Введите адрес электронной почты");
            localizationService.AddTranslation("en", "Email daxil edin", "Enter email");

            var message = localizationService.Translate("az", "Email daxil edin");
            Console.WriteLine(message);


            while (true)
            {
                string command = Console.ReadLine()!;

                switch (command)
                {
                    case "/register":
                        RegisterCommand adminDashboard = new RegisterCommand();
                        adminDashboard.Handle();
                        break;
                    case "/login":
                        LoginCommand loginCommand = new LoginCommand();
                        loginCommand.Handle();
                        break;
                    case "/update-language-preference":
                        LanguageCommand languageCommand = new LanguageCommand();
                        languageCommand.Handle();
                        break;
                    case "/exit":
                        Console.WriteLine("Bye-bye");
                        return;
                    default:
                        Console.WriteLine("Invalid command, pls try again");
                        break;
                }
            }
        }
    }
}
