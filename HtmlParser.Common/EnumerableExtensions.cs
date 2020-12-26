using System.Collections.Generic;
using System.Linq;

namespace HtmlParser.Common
{
    /// <summary>
    /// Extensions for <see cref="IEnumerable{T}"/>
    /// </summary>
    public static class EnumerableExtensions
    {
        /// <summary>
        /// Gets valid data from <see cref="IEnumerable{T}"/> collection
        /// </summary>
        /// <param name="elementsData">Data from html elements</param>
        /// <returns>Collection of valid data</returns>
        public static IEnumerable<string> GetValidData(this IEnumerable<string> elementsData)
        {
            var result = new List<string>();
            foreach (var data in elementsData)
            {
                result.Add(data.AdjustParsedText());
            }

            return result.Where(x => !x.Contains('\n'));
        }
    }
}
