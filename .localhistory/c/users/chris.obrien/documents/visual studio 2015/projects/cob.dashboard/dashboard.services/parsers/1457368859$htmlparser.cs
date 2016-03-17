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
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Dtos;

    using HtmlAgilityPack;

    /// <summary>
    /// The html parser.
    /// </summary>
    public class HtmlParser
    {
        /// <summary>
        /// The tax search text.
        /// </summary>
        private const string TaxSearchText = "Tax due:";

        /// <summary>
        /// The valid tax.
        /// </summary>
        private const string ValidTaxHtmlClass = "isValidTax";

        /// <summary>
        /// The is taxed text.
        /// </summary>
        private const string IsTaxedText = "✔ Taxed";

        /// <summary>
        /// The is motd text.
        /// </summary>
        private const string IsMotdText = "✔ MOT";

        /// <summary>
        /// The valid mot html class.
        /// </summary>
        private const string ValidMotHtmlClass = "isValidMot";

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

            var vehicle = new Vehicle
                              {
                                  RoadTax = BuildTaxResults(GetTaxResults(document)),
                                  Mot = BuildMotResults(GetMoxResults(document))
                              };
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
        private static IList<Html> GetTaxResults(HtmlDocument document)
        {
            var results =
                document.DocumentNode.Descendants()
                    .Where(x => x.Name == "div")
                    .Where(x => x.InnerHtml.Contains(ValidTaxHtmlClass))
                    .Select(x => new Html { Text = x.InnerHtml });

            return results.ToList();
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
        private static Requirement BuildTaxResults(IList<Html> results)
        {
            var tax = new Requirement();
            if (results.Any(x => x.Text.Contains(IsTaxedText)))
            {
                tax.IsValid = true;
            }
            
            tax.ExpiryDate = GetTaxDate(results.Last(x => x.Text.Contains(TaxSearchText)).Text);

            return tax;
        }

        /// <summary>
        /// The build mot results.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <returns>
        /// The <see cref="Requirement"/>.
        /// </returns>
        private static Requirement BuildMotResults(IList<Html> results)
        {
            var tax = new Requirement();
            if (results.Any(x => x.Text.Contains(IsMotdText)))
            {
                tax.IsValid = true;
            }

            tax.ExpiryDate = GetTaxDate(results.Last(x => x.Text.Contains(TaxSearchText)).Text);

            return tax;
        }

        /// <summary>
        /// The get tax date.
        /// </summary>
        /// <param name="html">
        /// The html.
        /// </param>
        /// <returns>
        /// The <see cref="DateTime"/>.
        /// </returns>
        private static DateTime? GetTaxDate(string html)
        {
            if (!html.Contains(TaxSearchText))
            {
                return null;
            }

            var dateStartIndex = html.IndexOf(TaxSearchText, StringComparison.Ordinal) + TaxSearchText.Length;
            var dateEndIndex = html.IndexOf("</p>", dateStartIndex, StringComparison.Ordinal);
            var dateString = html.Substring(dateStartIndex, dateEndIndex - dateStartIndex);
            return DateTime.Parse(dateString);
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
        private static IList<Html> GetMoxResults(HtmlDocument document)
        {
            return
                document.DocumentNode.Descendants()
                    .Where(x => x.Name == "div")
                    .Where(x => x.InnerHtml.Contains(ValidMotHtmlClass))
                    .Select(x => new Html { Text = x.InnerHtml }).ToList();
        }
    }
}
