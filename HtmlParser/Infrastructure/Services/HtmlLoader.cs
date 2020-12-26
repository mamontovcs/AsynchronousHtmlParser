using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using HtmlParser.Infrastructure.Interfaces;

namespace HtmlParser.Infrastructure.Services
{
    /// <summary>
    /// Loader for html page
    /// </summary>
    internal class HtmlLoader : IHtmlLoader
    {
        /// <summary>
        /// Provides a base class for sending HTTP 
        /// requests and receiving HTTP responsesfrom a resource 
        /// identified by a URI.
        /// </summary>
        private readonly HttpClient httpClient;

        /// <summary>
        /// URL for downloading page
        /// </summary>
        private readonly string _url = $"{AppConstants.BaseUrl}/{AppConstants.Sufix}";

        /// <summary>
        /// Creates instance of <see cref="HtmlLoader"/>
        /// </summary>
        /// <param name="httpClient">Provides a base class for sending HTTP requests and receiving HTTP 
        /// responses from a resource identified by a URI.</param>
        public HtmlLoader(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        /// <summary>
        /// Gets sourse html page by its id
        /// </summary>
        /// <param name="id">Page identifier</param>
        /// <returns>Content of html page</returns>
        public async Task<string> GetSourseById(int id)
        {
            var currentUrl = _url.Replace("{CurrentId}", id.ToString());
            var cleintReponse = await httpClient.GetAsync(currentUrl);
            string sourse = null;

            if (cleintReponse != null && cleintReponse.StatusCode == HttpStatusCode.OK)
            {
                sourse = await cleintReponse.Content.ReadAsStringAsync();
            }

            return sourse;
        }
    }
}
