namespace System.IO
{
    public class TextFileIOResult
    {
        public readonly bool   success;
        public readonly string text;

        public TextFileIOResult(bool success, string text)
        {
            this.success = success;
            this.text    = text;
        }
    }
}