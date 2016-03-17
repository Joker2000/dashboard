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
    using System.Text.RegularExpressions;

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
            var strippedHtml = Regex.Replace(html, @"\r|\n", "");


        }
    }
}
