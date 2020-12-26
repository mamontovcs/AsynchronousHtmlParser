using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DotSpinners;
using HtmlParser.Common;
using HtmlParser.Infrastructure;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            var task = Run();

            var spinner = new DotSpinner(SpinnerTypes.Loading, task)
            {
                TextAlignment = DotSpinners.Models.TextAlignment.Center
            }.Start();

            Console.Clear();

            var validData = task.Result.GetValidData();
            ShowData(validData);

            Console.ReadKey();
        }

        /// <summary>
        /// Runs parsing asynchronously
        /// </summary>
        /// <returns>Collection of parsed data</returns>
        private static async Task<IEnumerable<string>> Run()
        {
            var dependenciesFactory = new ParserDependenciesFactory();

            var facade = dependenciesFactory.CreateParsingFacade(1, 2);

            return await Task.Run(() => facade.RunParser());
        }

        /// <summary>
        /// Shows data in <see cref="Console"/>
        /// </summary>
        /// <param name="parsedData">Data to show in console</param>
        static void ShowData(IEnumerable<string> parsedData)
        {
            foreach (var text in parsedData)
            {
                Console.WriteLine(text);
            }
        }
    }
}
