// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IHtmlParser.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the IHtmlParser type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dashboard.Services.Parsers
{
    using Dashboard.Services.Dtos;

    /// <summary>
    /// The HtmlParser interface.
    /// </summary>
    interface IHtmlParser
    {
        /// <summary>
        /// The parse.
        /// </summary>
        /// <param name="html">
        /// The html.
        /// </param>
        /// <returns>
        /// The <see cref="Vehicle"/>.
        /// </returns>
        Vehicle Parse(string html);
    }
}
