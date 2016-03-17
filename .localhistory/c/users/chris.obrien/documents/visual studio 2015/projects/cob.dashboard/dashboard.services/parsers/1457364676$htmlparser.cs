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
        private static object GetTaxResults(HtmlDocument document)
        {
            return
                document.DocumentNode.Descendants()
                    .Where(x => x.Name == "div")
                    .Where(x => x.InnerHtml.Contains("isValidTax"))
                    .Select(x => new { text = x.InnerHtml });
        }
    }
}
