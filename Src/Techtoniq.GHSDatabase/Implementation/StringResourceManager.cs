﻿using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;

namespace Techtoniq.GHSDatabase
{
    internal static class StringResourceManager
    {
        private static readonly ResourceManager _resourceManager = new ResourceManager("Techtoniq.GHSDatabase.Properties.Resources", Assembly.GetExecutingAssembly());

        public static CultureInfo GetCultureInfo(string cultureName) 
        { 
            return CultureInfo.CreateSpecificCulture(cultureName);
        }

        public static string GetHazardClassString(HazardClass hazardClassKey, CultureInfo cultureInfo)
        {
            return _resourceManager.GetString($"Class_{hazardClassKey}", cultureInfo);
        }
        public static string GetHazardCategoryString(HazardCategory hazardCategoryKey, CultureInfo cultureInfo)
        {
            return _resourceManager.GetString($"Category_{hazardCategoryKey}", cultureInfo);
        }
        public static string GetSignalWordString(SignalWord signalWordKey, CultureInfo cultureInfo)
        {
            return _resourceManager.GetString($"SignalWord_{signalWordKey}", cultureInfo);
        }

        public static string GetHazardPhraseString(string hCode, CultureInfo cultureInfo)
        {
            return _resourceManager.GetString(hCode, cultureInfo);
        }

        public static string GetPCodePhraseString(string pCode, CultureInfo cultureInfo)
        {
            var pcodes = pCode.Split('+');
            var phrases = pcodes.Select(p => _resourceManager.GetString(p, cultureInfo)).Where(p => !string.IsNullOrWhiteSpace(p)).ToArray();
            if (pcodes.Length != phrases.Length)
                return null;
            var phrase = string.Join(" ", phrases);

            return phrase;
        }        
    }
}
