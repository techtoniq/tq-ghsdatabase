namespace Techtoniq.GHSDatabase
{
    public class Hazard : IHazard
    {
        public string Code { get; set; }
        public string Phrase { get; set; }
        public byte[] PictogramImage { get; set; }

        internal IHazard Copy()
        {
            return (IHazard)this.MemberwiseClone();
        }
    }
}
