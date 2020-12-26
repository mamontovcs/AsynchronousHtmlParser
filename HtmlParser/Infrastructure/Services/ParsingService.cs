using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using HtmlParser.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace HtmlParser.Services
{
    /// <summary>
    /// Provides logic for parsing html elements
    /// </summary>
    internal class ParsingService : IParsingService<IEnumerable<string>>
    {
        /// <summary>
        /// Parses data from html elements
        /// </summary>
        /// <param name="document">Serves as an entry point to the content of an HTML document</param>
        /// <returns>Collection of parsed data</returns>
        public IEnumerable<string> Parse(IHtmlDocument document)
        {
            var dataFromElements = new List<string>();
            var elements = GetElements(document);

            foreach (var item in elements)
            {
                dataFromElements.Add(item.TextContent);
            }

            return dataFromElements;
        }

        /// <summary>
        /// Gets elemetns from html page
        /// </summary>
        /// <param name="document">Serves as an entry point to the content of an HTML document</param>
        /// <returns>Collection of html elements</returns>
        private IEnumerable<IElement> GetElements(IHtmlDocument document)
        {
            return document.QuerySelectorAll("a").Where(x => x.ClassName != null &&
            x.ClassName.Contains("detailsLink"));
        }
    }
}
