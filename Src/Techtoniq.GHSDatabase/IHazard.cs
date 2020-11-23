using System.Collections.Generic;

namespace Techtoniq.GHSDatabase
{
    public interface IHazard
    {
        string Class { get; set; }
        IList<string> Categories { get; }
        byte[] PictogramImage { get; set; }
        string SignalWord { get; set; }
        string HCode { get; set; }
        string Phrase { get; set; }
        IList<string> PCodes { get; }
    }
}
