namespace Techtoniq.GHSDatabase
{
    public class PCode : IPCode
    {
        public string Code { get; }
        public string Phrase { get; internal set; }

        internal PCode(string code)
        {
            Code = code;
        }
    }
}
