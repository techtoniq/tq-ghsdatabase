using System.Collections.Generic;

namespace Techtoniq.GHSDatabase
{
    public class Hazard : IHazard
    {
        public string HCode { get; set; }
        public string Phrase { get; set; }
        public byte[] PictogramImage { get; set; }
        public IList<string> PCodes { get; set; }
        public string SignalWord { get; set; }
        public IList<string> Categories { get; }
        public string Class { get; set; }

        
        internal HazardClass ClassKey { get; set; }

        internal IList<HazardCategory> CategoryKeys { get; set; }

        internal SignalWord SignalWordKey { get; set; }

        public Hazard()
        {
            Categories = new List<string>();
            PCodes = new List<string>();
        }

        internal Hazard(HazardClass classKey, IList<HazardCategory> categoryKeys, byte[] pictogramImage, SignalWord signalWordKey, IList<string> pCodes)
            :this()
        {
            ClassKey = classKey;
            CategoryKeys = categoryKeys;
            PictogramImage = pictogramImage;
            SignalWordKey = signalWordKey;
            PCodes = pCodes;
        }

        internal IHazard Copy()
        {
            return (IHazard)this.MemberwiseClone();
        }
    }
}
