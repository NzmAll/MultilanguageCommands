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
        private readonly Dictionary<string, Dictionary<string, string>> _translations;

        public LocalizationService()
        {
            _translations = new Dictionary<string, Dictionary<string, string>>();
        }

        public void AddTranslation(string languageCode, string messageKey, string messageTranslation)
        {
            if (!_translations.ContainsKey(languageCode))
            {
                _translations.Add(languageCode, new Dictionary<string, string>());
            }

            _translations[languageCode][messageKey] = messageTranslation;
        }

        public string Translate(string languageCode, string messageKey)
        {
            if (_translations.TryGetValue(languageCode, out var languageTranslations))
            {
                if (languageTranslations.TryGetValue(messageKey, out var messageTranslation))
                {
                    return messageTranslation;
                }
            }

            return messageKey;
        }
    }

}