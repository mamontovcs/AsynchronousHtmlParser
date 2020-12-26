using HtmlParser.Interfaces;

namespace HtmlParser.Settings
{
    /// <summary>
    /// Settings for parsing html page
    /// </summary>
    internal class ParserSettings : IParserSettings
    {
        /// <summary>
        /// Creates instance of <see cref="ParserSettings"/>
        /// </summary>
        /// <param name="startPage">Start page pf parsing</param>
        /// <param name="endPage">End page pf parsing</param>
        public ParserSettings(int startPage, int endPage)
        {
            StartPage = startPage;
            EndPage = endPage;
        }

        /// <summary>
        /// Start page of parsing
        /// </summary>
        public int StartPage { get; set; }

        /// <summary>
        /// End page of parsing
        /// </summary>
        public int EndPage { get; set; }
    }
}
