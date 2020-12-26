using HtmlParser.Infrastructure.Interfaces;
using HtmlParser.Interfaces;
using AngleSharp.Html.Parser;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HtmlParser.Infrastructure.Services
{
    /// <summary>
    /// Provides logic for parsing html pages
    /// </summary>
    internal class ParsingFacade : IParsingFacade<string>
    {
        /// <summary>
        /// Provides logic for parsing html elements
        /// </summary>
        private readonly IParsingService<IEnumerable<string>> _parsingService;

        /// <summary>
        /// Settings fot parsing html pages
        /// </summary>
        private readonly IParserSettings _parserSettings;

        /// <summary>
        /// Loader for html page
        /// </summary>
        private readonly IHtmlLoader _htmlLoader;

        /// <summary>
        /// Creates instance of <see cref="ParsingFacade"/>
        /// </summary>
        /// <param name="parsingService">Provides logic for parsing html elements</param>
        /// <param name="parserSettings">Settings fot parsing html pages</param>
        /// <param name="htmlLoader">Loader for html page</param>
        public ParsingFacade(IParsingService<IEnumerable<string>> parsingService,
            IParserSettings parserSettings, IHtmlLoader htmlLoader)
        {
            _parsingService = parsingService;
            _parserSettings = parserSettings;
            _htmlLoader = htmlLoader;
        }

        /// <summary>
        /// Runs parsing algorithm
        /// </summary>
        /// <returns>Result of parsing html page</returns>
        public IEnumerable<string> RunParser()
        {
            return RunParse().Result;
        }

        /// <summary>
        /// Runs parsing algorithm asynchronously
        /// </summary>
        /// <returns>Result of parsing html page</returns>
        private async Task<IEnumerable<string>> RunParse()
        {
            var parsedData = new List<string>();
            for (int i = _parserSettings.StartPage; i <= _parserSettings.EndPage; i++)
            {
                var source = await _htmlLoader.GetSourseById(i);
                var parser = new AngleSharp.Html.Parser.HtmlParser();

                var document = await parser.ParseDocumentAsync(source);

                parsedData.AddRange(_parsingService.Parse(document));
            }

            return parsedData;
        }
    }
}
