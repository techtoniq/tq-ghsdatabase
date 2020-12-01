using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Techtoniq.GHSDatabase
{
    public class GhsDatabase : IGhsDatabase
    {
        private readonly Dictionary<string, IHazard> _database = new Dictionary<string, IHazard>()
        {
            { "H200", new Hazard(HazardClass.Explosives, new HazardCategory[]{ HazardCategory.UnstableExplosive}, Properties.Resources.ghs01, SignalWord.Danger, new string[]{"P201", "P202", "P281", "P372", "P373", "P380", "P401", "P501" }) },
            { "H201", new Hazard(HazardClass.Explosives, new HazardCategory[]{ HazardCategory.Div1_1}, Properties.Resources.ghs01, SignalWord.Danger, new string[]{"P210", "P230", "P240", "P250", "P280", "P370+P380", "P372", "P373", "P401", "P501" }) },
            { "H202", new Hazard(HazardClass.Explosives, new HazardCategory[]{ HazardCategory.Div1_2}, Properties.Resources.ghs01, SignalWord.Danger, new string[]{"P210", "P230", "P240", "P250", "P280", "P370+P380", "P372", "P373", "P401", "P501" }) },
            { "H203", new Hazard(HazardClass.Explosives, new HazardCategory[]{ HazardCategory.Div1_3}, Properties.Resources.ghs01, SignalWord.Danger, new string[]{"P210", "P230", "P240", "P250", "P280", "P370+P380", "P372", "P373", "P401", "P501" }) },
            { "H204", new Hazard(HazardClass.Explosives, new HazardCategory[]{ HazardCategory.Div1_4}, Properties.Resources.ghs01, SignalWord.Warning, new string[]{"P210", "P240", "P250", "P280", "P370+P380", "P372", "P373", "P374", "P401", "P501" }) },
            { "H205", new Hazard(HazardClass.Explosives, new HazardCategory[]{ HazardCategory.Div1_5}, null, SignalWord.Danger, new string[]{"P210", "P230", "P234", "P240", "P250", "P280", "P370+P380", "P372", "P373", "P401", "P501" }) },
        };
       
        public IHazard Get(string hCode, string cultureName = "en")
        {
            if(string.IsNullOrWhiteSpace(hCode))
            {
                throw new ArgumentException("Null or empty hazard code.", nameof(hCode));
            }
            
            if (string.IsNullOrWhiteSpace(cultureName))
            {
                throw new ArgumentException("Null or empty culture name.", nameof(cultureName));
            }

            if (!_database.ContainsKey(hCode))
                return null;

            Hazard hazard = ((Hazard)_database[hCode]).Copy() as Hazard;

            CultureInfo cultureInfo = StringResourceManager.GetCultureInfo(cultureName);
            hazard.Class = StringResourceManager.GetHazardClassString(hazard.ClassKey, cultureInfo);
            foreach(var categoryKey in hazard.CategoryKeys)
            {
                hazard.Categories.Add(StringResourceManager.GetHazardCategoryString(categoryKey, cultureInfo));
            }
            hazard.SignalWord = StringResourceManager.GetSignalWordString(hazard.SignalWordKey, cultureInfo);
            hazard.HCode = hCode;
            hazard.Phrase = StringResourceManager.GetHazardPhraseString(hazard.HCode, cultureInfo);

            return hazard;
        }

        public IList<IHazard> GetAll(string cultureName = "en")
        {
            List<IHazard> all = new List<IHazard>();

            foreach(var hazard in _database)
            {
                all.Add(Get(hazard.Key, cultureName));
            }

            return all.OrderBy(h => h.HCode).ToList();
        }
    }
}
