namespace HtmlParser.Interfaces
{
    /// <summary>
    /// Settings for parsing html page
    /// </summary>
    internal interface IParserSettings
    {
        /// <summary>
        /// Start page of parsing
        /// </summary>
        int StartPage { get; set; }

        /// <summary>
        /// End page of parsing
        /// </summary>
        int EndPage { get; set; }
    }
}
