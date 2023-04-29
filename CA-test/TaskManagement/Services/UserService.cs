using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Contants;
using TaskManagement.Database.Models;

namespace TaskManagement.Services
{
    public static class UserService
    {
        public static User CurrentUser { get; set; }
        public static Language LanguagePreference { get; set; } = Language.Azerbaijani;

        public static void UpdateLanguagePreference(Language language)
        {
            LanguagePreference = language;
        }
    }
}
