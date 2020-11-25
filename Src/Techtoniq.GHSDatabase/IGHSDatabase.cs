using System.Collections.Generic;

namespace Techtoniq.GHSDatabase
{
    public interface IGhsDatabase
    {
        IHazard Get(string hCode, string cultureName = "en");
        IList<IHazard> GetAll(string cultureName = "en");
    }
}
