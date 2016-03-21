// --------------------------------------------------------------------------------------------------------------------
// <copyright file="VehicleHtmlParser.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the VehicleHtmlParser type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dashboard.API.Services.Parsers
{
    using System.Collections.Generic;
    using System.Linq;

    using HtmlAgilityPack;

    /// <summary>
    /// The Email html parser.
    /// </summary>
    public class EmailHtmlParser
    {
        /// <summary>
        /// The parse.
        /// </summary>
        /// <param name="html">
        /// The html.
        /// </param>
        /// <returns>
        /// The <see cref="IEnumerable{String}"/>.
        /// </returns>
        public IEnumerable<string> Parse(string html)
        {
            var document = new HtmlDocument();
            document.LoadHtml(html);
            var emails = this.FindEmails(document).ToList();
            return emails;
        }

        /// <summary>
        /// The find emails.
        /// </summary>
        /// <param name="document">
        /// The document.
        /// </param>
        /// <returns>
        /// The <see cref="IList{String}"/>.
        /// </returns>
        private IEnumerable<string> FindEmails(HtmlDocument document)
        {
            var anchors = document.DocumentNode.SelectNodes("//a[@href]");
            
            foreach (var anchor in anchors)
            {
                if (anchor == null)
                {
                    continue;
                }
                
                var href = anchor.Attributes["href"].Value; // TODO: Check if href exists

                if (href.Contains("mailto:"))
                {
                    yield return href.Replace("mailto:", string.Empty);
                }
            }
        }
    }
}
