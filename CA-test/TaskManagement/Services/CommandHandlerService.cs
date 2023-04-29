using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Contants;

namespace TaskManagement.Services
{
    public class CommandHandlerService
    {
        public void HandleUpdateLanguagePreferenceCommand(Language language)
        {
            UserService.UpdateLanguagePreference(language);
            Console.WriteLine($"Language preference has been updated to {language}");
        }
    }

}
