using System.Collections.Generic;

namespace Techtoniq.GHSDatabase
{
    public class Hazard : IHazard
    {
        public string Code { get; internal set; }
        public string Phrase { get; internal set; }
        public byte[] PictogramImage { get; }
        public IList<IPCode> PCodes { get; }
        public string SignalWord { get; internal set; }
        public IList<string> Categories { get; }
        public string Class { get; internal set; }        
        internal HazardClass ClassKey { get; }
        internal IList<HazardCategory> CategoryKeys { get; }
        internal SignalWord SignalWordKey { get; }

        internal Hazard(HazardClass classKey, IList<HazardCategory> categoryKeys, byte[] pictogramImage, SignalWord signalWordKey, IList<IPCode> pCodes)
        {
            ClassKey = classKey;
            CategoryKeys = categoryKeys;
            PictogramImage = pictogramImage;
            SignalWordKey = signalWordKey;
            PCodes = pCodes;
            Categories = new List<string>();
        }

        internal IHazard Copy()
        {
            return (IHazard)this.MemberwiseClone();
        }
    }
}
