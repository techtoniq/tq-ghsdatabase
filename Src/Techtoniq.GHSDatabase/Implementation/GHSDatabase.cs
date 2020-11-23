﻿using System;
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
            { "H200", new Hazard(HazardClass.Explosives, new HazardCategory[]{ HazardCategory.UnstableExplosive}, Properties.Resources.ghs01, SignalWord.Danger, new string[]{"P201", "P202", "P281", "P372", "P373", "P380", "P401", "P501" }) },
        };


        private readonly ResourceManager _resourceManager = new ResourceManager("Techtoniq.GHSDatabase.Properties.Resources", Assembly.GetExecutingAssembly());


        public IHazard Get(string hcode, string cultureName = "en")
        {
            if(string.IsNullOrWhiteSpace(hcode))
            {
                throw new ArgumentException("Null or empty hazard code.", nameof(hcode));
            }
            
            if (string.IsNullOrWhiteSpace(cultureName))
            {
                throw new ArgumentException("Null or empty culture name.", nameof(cultureName));
            }

            if (!_database.ContainsKey(hcode))
                return null;

            Hazard hazard = ((Hazard)_database[hcode]).Copy() as Hazard;

            CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture(cultureName);
            hazard.Class = _resourceManager.GetString($"Class_{hazard.ClassKey}", cultureInfo);
            foreach(var categoryKey in hazard.CategoryKeys)
            {
                hazard.Categories.Add(_resourceManager.GetString($"Category_{categoryKey}", cultureInfo));
            }
            hazard.SignalWord = _resourceManager.GetString($"SignalWord_{hazard.SignalWordKey}", cultureInfo);
            hazard.HCode = hcode;            
            hazard.Phrase = _resourceManager.GetString(hazard.HCode, cultureInfo);

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
