namespace HtmlParser.Interfaces
{
    /// <summary>
    /// Internal factory intended for creating dependencies for <see cref="IParsingFacade{T}"/>
    /// </summary>
    /// <typeparam name="T">Data type</typeparam>
    internal interface IParserDependenciesFactory<T>
    {
        /// <summary>
        /// Creates instance of <see cref="ParsingFacade"/>
        /// </summary>
        /// <param name="startPage">Start point pf parsing</param>
        /// <param name="endPage">End point pf parsing</param>
        /// <returns>Instance of <see cref="ParsingFacade"/></returns>
        IParsingFacade<T> CreateParsingFacade(int startPage, int endPage);
    }
}
