using System.Threading.Tasks;

namespace HtmlParser.Infrastructure.Interfaces
{
    /// <summary>
    /// Interface for html page loader
    /// </summary>
    internal interface IHtmlLoader
    {
        /// <summary>
        /// Gets sourse html page by its id
        /// </summary>
        /// <param name="id">Page identifier</param>
        /// <returns>Content of html page</returns>
        Task<string> GetSourseById(int id);
    }
}
