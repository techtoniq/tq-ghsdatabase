using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Techtoniq.GHSDatabase
{
    public class GhsDatabase : IGhsDatabase
    {
        #region Data

        private readonly List<KeyValuePair<string, IHazard>> _database = new List<KeyValuePair<string, IHazard>>()
        {
            { new KeyValuePair<string, IHazard>("H200", new Hazard(HazardClass.Explosives, new HazardCategory[]{ HazardCategory.UnstableExplosive}, Properties.Resources.ghs01, SignalWord.Danger, new PCode[]{ new PCode("P201"), new PCode("P202"), new PCode("P281"), new PCode("P372"), new PCode("P373"), new PCode("P380"), new PCode("P401"), new PCode("P501")}) ) },
            { new KeyValuePair<string, IHazard>("H201", new Hazard(HazardClass.Explosives, new HazardCategory[]{ HazardCategory.Div1_1}, Properties.Resources.ghs01, SignalWord.Danger, new PCode[]{new PCode("P210"), new PCode("P230"), new PCode("P240"), new PCode("P250"), new PCode("P280"), new PCode("P370+P380"), new PCode("P372"), new PCode("P373"), new PCode("P401"), new PCode("P501") }) )},
            { new KeyValuePair<string, IHazard>("H202", new Hazard(HazardClass.Explosives, new HazardCategory[]{ HazardCategory.Div1_2}, Properties.Resources.ghs01, SignalWord.Danger, new PCode[]{new PCode("P210"), new PCode("P230"), new PCode("P240"), new PCode("P250"), new PCode("P280"), new PCode("P370+P380"), new PCode("P372"), new PCode("P373"), new PCode("P401"), new PCode("P501") }) )},
            { new KeyValuePair<string, IHazard>("H203", new Hazard(HazardClass.Explosives, new HazardCategory[]{ HazardCategory.Div1_3}, Properties.Resources.ghs01, SignalWord.Danger, new PCode[]{new PCode("P210"), new PCode("P230"), new PCode("P240"), new PCode("P250"), new PCode("P280"), new PCode("P370+P380"), new PCode("P372"), new PCode("P373"), new PCode("P401"), new PCode("P501") }) )},
            { new KeyValuePair<string, IHazard>("H204", new Hazard(HazardClass.Explosives, new HazardCategory[]{ HazardCategory.Div1_4}, Properties.Resources.ghs01, SignalWord.Warning, new PCode[]{new PCode("P210"), new PCode("P240"), new PCode("P250"), new PCode("P280"), new PCode("P370+P380"), new PCode("P372"), new PCode("P373"), new PCode("P374"), new PCode("P401"), new PCode("P501") }) )},
            { new KeyValuePair<string, IHazard>("H205", new Hazard(HazardClass.Explosives, new HazardCategory[]{ HazardCategory.Div1_5}, null, SignalWord.Danger, new PCode[]{new PCode("P210"), new PCode("P230"), new PCode("P234"), new PCode("P240"), new PCode("P250"), new PCode("P280"), new PCode("P370+P380"), new PCode("P372"), new PCode("P373"), new PCode("P401"), new PCode("P501") }) )},

            { new KeyValuePair<string, IHazard>("H220", new Hazard(HazardClass.FlammableGases, new HazardCategory[]{ HazardCategory.Category1}, Properties.Resources.ghs02, SignalWord.Danger, new PCode[]{new PCode("P210"), new PCode("P377"), new PCode("P381"), new PCode("P403") }) )},
            { new KeyValuePair<string, IHazard>("H221", new Hazard(HazardClass.FlammableGases, new HazardCategory[]{ HazardCategory.Category2}, null, SignalWord.Warning, new PCode[]{new PCode("P210"), new PCode("P377"), new PCode("P381"), new PCode("P403") }) )},

            { new KeyValuePair<string, IHazard>("H222", new Hazard(HazardClass.FlammableAerosoles, new HazardCategory[]{ HazardCategory.Category1}, Properties.Resources.ghs02, SignalWord.Danger, new PCode[]{new PCode("P210"), new PCode("P211"), new PCode("P251"), new PCode("P410+P412") }) )},
            { new KeyValuePair<string, IHazard>("H223", new Hazard(HazardClass.FlammableAerosoles, new HazardCategory[]{ HazardCategory.Category2}, Properties.Resources.ghs02, SignalWord.Warning, new PCode[]{new PCode("P210"), new PCode("P211"), new PCode("P251"), new PCode("P410+P412") }) )},

            { new KeyValuePair<string, IHazard>("H224", new Hazard(HazardClass.FlammableLiquids, new HazardCategory[]{ HazardCategory.Category1}, Properties.Resources.ghs02, SignalWord.Danger, new PCode[]{new PCode("P210"), new PCode("P233"), new PCode("P240"), new PCode("P241"), new PCode("P242"), new PCode("P243"), new PCode("P280"), new PCode("P303+P361+P353"), new PCode("P370+P378"), new PCode("P403+P235"), new PCode("P501") }) )},
            { new KeyValuePair<string, IHazard>("H225", new Hazard(HazardClass.FlammableLiquids, new HazardCategory[]{ HazardCategory.Category2}, Properties.Resources.ghs02, SignalWord.Danger, new PCode[]{new PCode("P210"), new PCode("P233"), new PCode("P240"), new PCode("P241"), new PCode("P242"), new PCode("P243"), new PCode("P280"), new PCode("P303+P361+P353"), new PCode("P370+P378"), new PCode("P403+P235"), new PCode("P501") }) )},
            { new KeyValuePair<string, IHazard>("H226", new Hazard(HazardClass.FlammableLiquids, new HazardCategory[]{ HazardCategory.Category3}, Properties.Resources.ghs02, SignalWord.Warning, new PCode[]{new PCode("P210"), new PCode("P233"), new PCode("P240"), new PCode("P241"), new PCode("P242"), new PCode("P243"), new PCode("P280"), new PCode("P303+P361+P353"), new PCode("P370+P378"), new PCode("P403+P235"), new PCode("P501") }) )},

            { new KeyValuePair<string, IHazard>("H228", new Hazard(HazardClass.FlammableSolids, new HazardCategory[]{ HazardCategory.Category1}, Properties.Resources.ghs02, SignalWord.Danger, new PCode[]{new PCode("P210"), new PCode("P240"), new PCode("P241"), new PCode("P280"), new PCode("P370+P378") }) )},
            { new KeyValuePair<string, IHazard>("H228", new Hazard(HazardClass.FlammableSolids, new HazardCategory[]{ HazardCategory.Category2}, Properties.Resources.ghs02, SignalWord.Warning, new PCode[]{new PCode("P210"), new PCode("P240"), new PCode("P241"), new PCode("P280"), new PCode("P370+P378") }) )},
        };

        #endregion Data

        public IList<IHazard> Get(string code, string cultureName = "en")
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

            // Find the database entries.

            var hazards = FindHazardsByCode(code);
            if(null == hazards || 0 == hazards.Count())
                return null;

            // Populate the culture-specific strings.

            CultureInfo cultureInfo = StringResourceManager.GetCultureInfo(cultureName);

            foreach(var ih in hazards)
            {
                var hazard = ih as Hazard;
                hazard.Class = StringResourceManager.GetHazardClassString(hazard.ClassKey, cultureInfo);
                hazard.SignalWord = StringResourceManager.GetSignalWordString(hazard.SignalWordKey, cultureInfo);
                hazard.Phrase = StringResourceManager.GetHazardPhraseString(hazard.Code, cultureInfo);
                foreach (var categoryKey in hazard.CategoryKeys)
                {
                    hazard.Categories.Add(StringResourceManager.GetHazardCategoryString(categoryKey, cultureInfo));
                }
                foreach (var pcode in hazard.PCodes)
                {
                    var p = pcode as PCode;
                    p.Phrase = StringResourceManager.GetPCodePhraseString(pcode.Code, cultureInfo);
                }
            }

            return hazards;
        }

        public IList<IHazard> GetAll(string cultureName = "en")
        {
            var distinctCodes = GetDistinctHazardCodes();

            List<IHazard> all = new List<IHazard>();
            foreach(var hcode in distinctCodes)
            {
                all.AddRange(Get(hcode, cultureName));
            }

            return all.OrderBy(h => h.Code).ToList();
        }


        private IList<IHazard> FindHazardsByCode(string code)
        {
            var values = from h in _database where h.Key.Equals(code) select h.Value;
            if (0 == values.Count())
                return null;

            List<IHazard> hazardCopies = new List<IHazard>();
            foreach(var h in values)
            {
                var hcopy = ((Hazard)h).Copy() as Hazard;
                hcopy.Code = code;
                hazardCopies.Add(hcopy);
            }
            return hazardCopies;
        }

        private IList<string> GetDistinctHazardCodes()
        {
            var hcodes = _database.Select(h => h.Key).Distinct().ToList();
            return hcodes;
        }
    }
}
