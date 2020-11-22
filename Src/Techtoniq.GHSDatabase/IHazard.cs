namespace Techtoniq.GHSDatabase
{
    public interface IHazard
    {
        string Code { get; set; }
        string Phrase { get; set; }

        byte[] PictogramImage { get; set; }
    }
}
