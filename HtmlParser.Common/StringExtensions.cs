namespace HtmlParser.Common
{
    /// <summary>
    /// Extensions for strings
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Adjusts parsed text from html element
        /// </summary>
        /// <param name="text">Text for adjusting</param>
        /// <returns>Adjusted text</returns>
        public static string AdjustParsedText(this string text)
        {
            return text.Replace("\n ", "").Replace("  ", "");
        }
    }
}
