using System.Collections.Generic;

namespace Techtoniq.GHSDatabase
{
    public interface IHazard
    {
        string Class { get; }
        IList<string> Categories { get; }
        IList<byte[]> PictogramImages { get; }
        string SignalWord { get; }
        string Code { get; }
        string Phrase { get; }
        IList<IPCode> PCodes { get; }
    }
}
