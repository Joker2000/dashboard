// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HtmlParser.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the HtmlParser type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dashboard.Services.Parsers
{
    using System.Collections.Generic;
    using System.Linq;

    using Dashboard.Services.Dtos;

    using HtmlAgilityPack;

    /// <summary>
    /// The html parser.
    /// </summary>
    public class HtmlParser
    {
        /// <summary>
        /// The parse.
        /// </summary>
        /// <param name="html">
        /// The html.
        /// </param>
        public void Parse(string html)
        {
            var document = new HtmlDocument();
            document.LoadHtml(html);

            var tax = BuildTaxResults(GetTaxResults(document));
            var mot = GetMoxResults(document);
        }

        /// <summary>
        /// The get tax results.
        /// </summary>
        /// <param name="document">
        /// The document.
        /// </param>
        /// <returns>
        /// The <see cref="object"/>.
        /// </returns>
        private static IEnumerable<Html> GetTaxResults(HtmlDocument document)
        {
            var results =
                document.DocumentNode.Descendants()
                    .Where(x => x.Name == "div")
                    .Where(x => x.InnerHtml.Contains("isValidTax"))
                    .Select(x => new Html { Text = x.InnerHtml });

            return results;
        }

        /// <summary>
        /// The build tax results.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <returns>
        /// The <see cref="Requirement"/>.
        /// </returns>
        private static Requirement BuildTaxResults(IEnumerable<Html> results)
        {
            var tax = new Requirement();
            if (results.Any(x => x.Text.Contains("✔ Taxed")))
            {
                tax.IsValid = true;
            }

            if (results.Any())
            {
                
            }

            return tax;
        }

        /// <summary>
        /// The get mox results.
        /// </summary>
        /// <param name="document">
        /// The document.
        /// </param>
        /// <returns>
        /// The <see cref="object"/>.
        /// </returns>
        private static object GetMoxResults(HtmlDocument document)
        {
            return
                document.DocumentNode.Descendants()
                    .Where(x => x.Name == "div")
                    .Where(x => x.InnerHtml.Contains("isValidMot"))
                    .Select(x => new { text = x.InnerHtml });
        }
    }
}
