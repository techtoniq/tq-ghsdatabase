using System.Collections.Generic;

namespace Techtoniq.GHSDatabase
{
    public interface IGhsDatabase
    {
        IHazard Get(string code, string cultureName = "en");
        IList<IHazard> GetAll(string cultureName = "en");
    }
}
