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
            { "H200", new Hazard(HazardClass.Explosives, new HazardCategory[]{ HazardCategory.UnstableExplosive}, Properties.Resources.ghs01, SignalWord.Danger, new PCode[]{ new PCode("P201"), new PCode("P202"), new PCode("P281"), new PCode("P372"), new PCode("P373"), new PCode("P380"), new PCode("P401"), new PCode("P501")}) },
            { "H201", new Hazard(HazardClass.Explosives, new HazardCategory[]{ HazardCategory.Div1_1}, Properties.Resources.ghs01, SignalWord.Danger, new PCode[]{new PCode("P210"), new PCode("P230"), new PCode("P240"), new PCode("P250"), new PCode("P280"), new PCode("P370+P380"), new PCode("P372"), new PCode("P373"), new PCode("P401"), new PCode("P501") }) },
            { "H202", new Hazard(HazardClass.Explosives, new HazardCategory[]{ HazardCategory.Div1_2}, Properties.Resources.ghs01, SignalWord.Danger, new PCode[]{new PCode("P210"), new PCode("P230"), new PCode("P240"), new PCode("P250"), new PCode("P280"), new PCode("P370+P380"), new PCode("P372"), new PCode("P373"), new PCode("P401"), new PCode("P501") }) },
            { "H203", new Hazard(HazardClass.Explosives, new HazardCategory[]{ HazardCategory.Div1_3}, Properties.Resources.ghs01, SignalWord.Danger, new PCode[]{new PCode("P210"), new PCode("P230"), new PCode("P240"), new PCode("P250"), new PCode("P280"), new PCode("P370+P380"), new PCode("P372"), new PCode("P373"), new PCode("P401"), new PCode("P501") }) },
            { "H204", new Hazard(HazardClass.Explosives, new HazardCategory[]{ HazardCategory.Div1_4}, Properties.Resources.ghs01, SignalWord.Warning, new PCode[]{new PCode("P210"), new PCode("P240"), new PCode("P250"), new PCode("P280"), new PCode("P370+P380"), new PCode("P372"), new PCode("P373"), new PCode("P374"), new PCode("P401"), new PCode("P501") }) },
            { "H205", new Hazard(HazardClass.Explosives, new HazardCategory[]{ HazardCategory.Div1_5}, null, SignalWord.Danger, new PCode[]{new PCode("P210"), new PCode("P230"), new PCode("P234"), new PCode("P240"), new PCode("P250"), new PCode("P280"), new PCode("P370+P380"), new PCode("P372"), new PCode("P373"), new PCode("P401"), new PCode("P501") }) },
        };
       
        public IHazard Get(string code, string cultureName = "en")
        {
            // Validate the arguments.

            if(string.IsNullOrWhiteSpace(code))
            {
                throw new ArgumentException("Null or empty hazard code.", nameof(code));
            }
            
            if (string.IsNullOrWhiteSpace(cultureName))
            {
                throw new ArgumentException("Null or empty culture name.", nameof(cultureName));
            }

            // Find the database entry.

            if (!_database.ContainsKey(code))
                return null;

            // Copy the hazard as we're going to populate culture-specific strings in it.

            Hazard hazard = ((Hazard)_database[code]).Copy() as Hazard;

            // Populate the culture-specific fields.

            CultureInfo cultureInfo = StringResourceManager.GetCultureInfo(cultureName);

            hazard.Class = StringResourceManager.GetHazardClassString(hazard.ClassKey, cultureInfo);
            foreach(var categoryKey in hazard.CategoryKeys)
            {
                hazard.Categories.Add(StringResourceManager.GetHazardCategoryString(categoryKey, cultureInfo));
            }
            hazard.SignalWord = StringResourceManager.GetSignalWordString(hazard.SignalWordKey, cultureInfo);
            hazard.Code = code;
            hazard.Phrase = StringResourceManager.GetHazardPhraseString(hazard.Code, cultureInfo);
            foreach(var pcode in hazard.PCodes)
            {
                var p = pcode as PCode;
                p.Phrase = StringResourceManager.GetPCodePhraseString(pcode.Code, cultureInfo);
            }

            return hazard;
        }

        public IList<IHazard> GetAll(string cultureName = "en")
        {
            List<IHazard> all = new List<IHazard>();

            foreach(var hazard in _database)
            {
                all.Add(Get(hazard.Key, cultureName));
            }

            return all.OrderBy(h => h.Code).ToList();
        }
    }
}
