using AngleSharp.Html.Dom;

namespace HtmlParser.Interfaces
{
    /// <summary>
    /// Provides logic for parsing html elements
    /// </summary>
    /// <typeparam name="T">Data type</typeparam>
    internal interface IParsingService<T>
    {
        /// <summary>
        /// Parses data from html elements
        /// </summary>
        /// <param name="document">Serves as an entry point to the content of an HTML document</param>
        /// <returns>Collection of parsed data</returns>
        T Parse(IHtmlDocument document);
    }
}
