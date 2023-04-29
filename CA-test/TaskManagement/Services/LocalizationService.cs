using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Resources;
using TaskManagement.Contants;

namespace TaskManagement.Services
{
    public class LocalizationService
    {
        private Dictionary<string, Dictionary<string, string>> 
            _translations = new Dictionary<string, Dictionary<string, string>>();


        public LocalizationService()
        {
            _translations = new Dictionary<string, Dictionary<string, string>>();
        }

        public void AddTranslation(string languageCode, string messageKey, string messageTranslation)
        {
            Dictionary<string, string> languageTranslations;
            if (!_translations.TryGetValue(languageCode, out languageTranslations))
            {
                languageTranslations = new Dictionary<string, string>();
                _translations.Add(languageCode, languageTranslations);
            }

            if (!languageTranslations.ContainsKey(messageKey))
            {
                languageTranslations.Add(messageKey, messageTranslation);
            }
        }

        public string Translate(string languageCode, string messageKey)
        {
            Dictionary<string, string> languageTranslations;
            if (_translations.TryGetValue(languageCode, out languageTranslations))
            {
                string messageTranslation;
                if (languageTranslations.TryGetValue(messageKey, out messageTranslation))
                {
                    return messageTranslation;
                }
            }
            return messageKey;
        }
    }



}