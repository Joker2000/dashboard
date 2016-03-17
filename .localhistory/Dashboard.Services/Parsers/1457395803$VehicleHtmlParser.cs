// --------------------------------------------------------------------------------------------------------------------
// <copyright file="VehicleHtmlParser.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the VehicleHtmlParser type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dashboard.Services.Parsers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using Dtos;

    using HtmlAgilityPack;

    /// <summary>
    /// The html parser.
    /// </summary>
    public class VehicleHtmlParser : IHtmlParser
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
        /// The div.
        /// </summary>
        private const string Div = "div";

        /// <summary>
        /// The closing paragraph tag.
        /// </summary>
        private const string ClosingParagraphTag = "</p>";

        /// <summary>
        /// The mot search text.
        /// </summary>
        private const string MotSearchText = "Expires:";

        private const string VehicleMake = "vehicle make";

        /// <summary>
        /// The parse.
        /// </summary>
        /// <param name="html">
        /// The html.
        /// </param>
        /// <returns>
        /// The <see cref="Vehicle"/>.
        /// </returns>
        public Vehicle Parse(string html)
        {
            var document = new HtmlDocument();
            document.LoadHtml(html);

            var vehicleDetails = BuildVehicleDetails(document);

            return new Vehicle
                              {
                                  RoadTax = BuildRequirement(GetResults(document, ValidTaxHtmlClass), IsTaxedText, TaxSearchText),
                                  Mot = BuildRequirement(GetResults(document, ValidMotHtmlClass), IsMotdText, MotSearchText)
                              };
        }

        /// <summary>
        /// The build vehicle details.
        /// </summary>
        /// <param name="document">
        /// The node.
        /// </param>
        /// <returns>
        /// The <see cref="Vehicle"/>.
        /// </returns>
        private static Vehicle BuildVehicleDetails(HtmlDocument document)
        {
            var vehicleDetailsElement = SearchFor(document, "class", "ul-data");

            var vehicleDetailsList = vehicleDetailsElement.ChildNodes.Where(x => x.Name == "li");

            var vehicleDetails =
                vehicleDetailsList.ToDictionary(
                    vehicleDetail => vehicleDetail.ChildNodes.Single(x => x.Name == "span").InnerText.Trim().ToLower(),
                    vehicleDetail => vehicleDetail.ChildNodes.Single(x => x.Name == "strong").InnerText.Trim());

            var regNumber = SearchFor(document, "class", "registrationNumber").InnerText;
            
            return new Vehicle
                       {
                           NumberPlate = regNumber,
                           Make = vehicleDetails[VehicleMake]
                       };
        }

        /// <summary>
        /// The search for.
        /// </summary>
        /// <param name="document">
        /// The document.
        /// </param>
        /// <param name="attribute">
        /// The attribute.
        /// </param>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <returns>
        /// The <see cref="IEnumerable{HtmlNode}"/>.
        /// </returns>
        private static HtmlNode SearchFor(HtmlDocument document, string attribute, string value)
        {
            return
                document.DocumentNode
                    .Descendants()
                    .Where(x => x.Attributes[attribute] != null)
                    .Last(x => x.Attributes[attribute].Value == value);
        }

        /// <summary>
        /// The search for.
        /// </summary>
        /// <param name="document">
        /// The document.
        /// </param>
        /// <param name="innerHtml">
        /// The inner html.
        /// </param>
        /// <returns>
        /// The <see cref="IEnumerable{HtmlNode}"/>.
        /// </returns>
        private static HtmlNode SearchFor(HtmlDocument document, string innerHtml)
        {
            return document.DocumentNode.Descendants().Last(x => x.InnerHtml.Contains(innerHtml));
        }

        /// <summary>
        /// The get results.
        /// </summary>
        /// <param name="document">
        /// The node.
        /// </param>
        /// <param name="searchText">
        /// The search Text.
        /// </param>
        /// <returns>
        /// The <see cref="object"/>.
        /// </returns>
        private static string GetResults(HtmlDocument document, string searchText)
        {
            var results =
                document.DocumentNode.Descendants()
                    .Where(x => x.Name == Div)
                    .Where(x => x.InnerHtml.Contains(searchText))
                    .Select(x => x.InnerHtml);

            return results.Last();
        }

        /// <summary>
        /// The build requirement.
        /// </summary>
        /// <param name="results">
        /// The results.
        /// </param>
        /// <param name="isValidSearchText">
        /// The is valid search text.
        /// </param>
        /// <param name="expiryDateSearchText">
        /// The expiry date search text.
        /// </param>
        /// <returns>
        /// The <see cref="Requirement"/>.
        /// </returns>
        private static Requirement BuildRequirement(string results, string isValidSearchText, string expiryDateSearchText)
        {
            var requirement = new Requirement();
            if (results.Contains(isValidSearchText))
            {
                requirement.IsValid = true;
            }
            
            requirement.ExpiryDate = GetDate(results, expiryDateSearchText);

            return requirement;
        }

        /// <summary>
        /// The get date.
        /// </summary>
        /// <param name="html">
        /// The html.
        /// </param>
        /// <param name="searchText">
        /// The search Text.
        /// </param>
        /// <returns>
        /// The <see cref="DateTime"/>.
        /// </returns>
        private static DateTime? GetDate(string html, string searchText)
        {
            if (!html.Contains(searchText))
            {
                return null;
            }

            var dateStartIndex = html.IndexOf(searchText, StringComparison.Ordinal) + searchText.Length;
            var dateEndIndex = html.IndexOf(ClosingParagraphTag, dateStartIndex, StringComparison.Ordinal);
            var dateString = html.Substring(dateStartIndex, dateEndIndex - dateStartIndex);

            return DateTime.Parse(dateString);
        }
    }
}
