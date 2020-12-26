using System.Collections.Generic;

namespace HtmlParser.Interfaces
{
    /// <summary>
    /// Provides logic for parsing html pages
    /// </summary>
    /// <typeparam name="T">Data type</typeparam>
    public interface IParsingFacade<T>
    {
        /// <summary>
        /// Runs parsing algorithm
        /// </summary>
        /// <returns>Result of parsing html page</returns>
        IEnumerable<T> RunParser();
    }
}
