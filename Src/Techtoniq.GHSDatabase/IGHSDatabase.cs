using System.Collections.Generic;

namespace Techtoniq.GHSDatabase
{
    public interface IGhsDatabase
    {
        /// <summary>
        /// Gets a hazard by hazard code.
        /// </summary>
        /// <param name="code">Hazard code ("H code").</param>
        /// <param name="cultureName">Language to return hazard information in (defaults to English).</param>
        /// <returns>Hazard object with information, or null if no match found.</returns>
        IHazard Get(string code, string cultureName = "en");

        /// <summary>
        /// Get all the hazards in the database.
        /// </summary>
        /// <param name="cultureName">Language to return hazard information in (defaults to English).</param>
        /// <returns>List of hazard objects with information.</returns>
        IList<IHazard> GetAll(string cultureName = "en");
    }
}
