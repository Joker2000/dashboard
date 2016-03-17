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

            var linksOnPage = from lnks in document.DocumentNode.Descendants()
                              where lnks.Name == "a" &&
                                   lnks.Attributes["href"] != null &&
                                   lnks.InnerText.Trim().Length > 0
                              select new
                              {
                                  Url = lnks.Attributes["href"].Value,
                                  Text = lnks.InnerText
                              };

            var taxResults =
                document.DocumentNode.Descendants()
                    .Where(x => x.Name == "div" && x.Id == "isValidTax")
                    .Select(x => new { text = x.InnerHtml });

            //var taxedDiv = document.GetElementbyId("isValidTax");
            //var root = document.DocumentNode;
        }
    }
}
