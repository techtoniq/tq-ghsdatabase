using System.Collections.Generic;

namespace Techtoniq.GHSDatabase
{
    public interface IGHSDatabase
    {
        IHazard Get(string code, string cultureName = "en");
        IList<IHazard> GetAll(string cultureName = "en");
    }
}
