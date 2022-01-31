namespace SkoleTools
{
    public static class EncodingFixer
    {
        public static string FixEncoding(this string s)
        {
            return s.Replace("Ã¦", "æ")
                    .Replace("Ã¸", "ø")
                    .Replace("Ã¥", "å")
                    .Replace("Ã©", "é")
                    .Replace("â€“", "-")
                    .Replace("", "")
                    .Replace("Â", "");
        }
    }
}