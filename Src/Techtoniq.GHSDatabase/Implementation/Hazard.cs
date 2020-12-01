using System.Collections.Generic;

namespace Techtoniq.GHSDatabase
{
    public class Hazard : IHazard
    {
        public string Code { get; set; }
        public string Phrase { get; set; }
        public byte[] PictogramImage { get; set; }
        public IList<IPCode> PCodes { get; set; }
        public string SignalWord { get; set; }
        public IList<string> Categories { get; }
        public string Class { get; set; }        
        internal HazardClass ClassKey { get; set; }
        internal IList<HazardCategory> CategoryKeys { get; set; }
        internal SignalWord SignalWordKey { get; set; }

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
