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
        /// <returns>List of hazards with matching code or null if no match found.</returns>
        /// <remarks>
        /// It's possible for multiple hazards to have the same code but different signal words and categories, 
        /// hence the need to return a list of hazards not a single item.
        /// </remarks>
        IList<IHazard> Get(string code, string cultureName = "en");

        /// <summary>
        /// Get all the hazards in the database.
        /// </summary>
        /// <param name="cultureName">Language to return hazard information in (defaults to English).</param>
        /// <returns>List of hazard objects with information.</returns>
        IList<IHazard> GetAll(string cultureName = "en");
    }
}
