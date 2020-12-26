using HtmlParser.Infrastructure.Services;
using HtmlParser.Interfaces;
using HtmlParser.Services;
using HtmlParser.Settings;
using System.Net.Http;

namespace HtmlParser.Infrastructure
{
    /// <summary>
    /// Internal factory intended for creating dependencies for <see cref="IParsingFacade{T}"/>
    /// </summary>
    public class ParserDependenciesFactory : IParserDependenciesFactory<string>
    {
        /// <summary>
        /// Creates instance of <see cref="ParsingFacade"/>
        /// </summary>
        /// <param name="startPage">Start point pf parsing</param>
        /// <param name="endPage">End point pf parsing</param>
        /// <returns>Instance of <see cref="ParsingFacade"/></returns>
        public IParsingFacade<string> CreateParsingFacade(int startPage, int endPage)
        {
            var parsingService = new ParsingService();
            var parsingSettings = new ParserSettings(startPage, endPage);
            var htmlClient = new HttpClient();
            var htmlLoader = new HtmlLoader(htmlClient);

            var parsingFacade = new ParsingFacade(parsingService, parsingSettings, htmlLoader);

            return parsingFacade;
        }
    }
}
