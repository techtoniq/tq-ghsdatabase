using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace Techtoniq.GHSDatabase
{
    public class GHSDatabase : IGHSDatabase
    {
        private readonly Dictionary<string, IHazard> _database = new Dictionary<string, IHazard>()
        {
            { "H200", new Hazard() { PictogramImage = Properties.Resources.ghs01 } },
        };


        public IHazard Get(string code, string cultureName = "en")
        {
            if(string.IsNullOrWhiteSpace(code))
            {
                throw new ArgumentException("Null or empty hazard code.", nameof(code));
            }

            if (string.IsNullOrWhiteSpace(cultureName))
            {
                throw new ArgumentException("Null or empty culture name.", nameof(cultureName));
            }

            if (!_database.ContainsKey(code))
                return null;

            IHazard hazard = ((Hazard)_database[code]).Copy();
            hazard.Code = code;

            CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture(cultureName);
            ResourceManager rm = new ResourceManager("Techtoniq.GHSDatabase.Properties.Resources", Assembly.GetExecutingAssembly());
            hazard.Phrase = rm.GetString(hazard.Code, cultureInfo);

            return hazard;
        }

        public IList<IHazard> GetAll(string cultureName = "en")
        {
            List<IHazard> all = new List<IHazard>();

            foreach(var hazard in _database)
            {
                all.Add(Get(hazard.Key, cultureName));
            }

            return all;
        }
    }
}
