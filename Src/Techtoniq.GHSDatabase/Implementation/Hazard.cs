using System.Collections.Generic;

namespace Techtoniq.GHSDatabase
{
    public class Hazard : IHazard
    {
        public string Code { get; internal set; }
        public string Phrase { get; internal set; }
        public IList<byte[]> PictogramImages { get; }
        public IList<IPCode> PCodes { get; }
        public string SignalWord { get; internal set; }
        public IList<string> Categories { get; }
        public string Class { get; internal set; }        
        internal HazardClass ClassKey { get; }
        internal IList<HazardCategory> CategoryKeys { get; }
        internal SignalWord SignalWordKey { get; }

        internal Hazard(HazardClass classKey, IList<HazardCategory> categoryKeys, IList<byte[]> pictogramImages, SignalWord signalWordKey, IList<IPCode> pCodes)
        {
            ClassKey = classKey;
            CategoryKeys = categoryKeys;
            SignalWordKey = signalWordKey;
            PCodes = pCodes;
            Categories = new List<string>();
            PictogramImages = pictogramImages ?? new List<byte[]>();
        }

        internal IHazard Copy()
        {
            return (IHazard)this.MemberwiseClone();
        }
    }
}
