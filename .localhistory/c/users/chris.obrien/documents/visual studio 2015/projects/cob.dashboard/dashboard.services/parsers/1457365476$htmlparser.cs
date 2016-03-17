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

            var tax = GetTaxResults(document);
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
        private static Requirement GetTaxResults(HtmlDocument document)
        {
            var results =
                document.DocumentNode.Descendants()
                    .Where(x => x.Name == "div")
                    .Where(x => x.InnerHtml.Contains("isValidTax"))
                    .Select(x => new { text = x.InnerHtml });

            var tax = new Requirement();
            if (results.Any(x => x.text.Contains("✔ Taxed")))
            {
                
            }
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
