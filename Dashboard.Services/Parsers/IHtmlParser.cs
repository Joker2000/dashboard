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
    using Dashboard.Dto;

    /// <summary>
    /// The HtmlParser interface.
    /// </summary>
    public interface IHtmlParser
    {
        /// <summary>
        /// The parse.
        /// </summary>
        /// <param name="html">
        /// The html.
        /// </param>
        /// <returns>
        /// The <see cref="VehicleDto"/>.
        /// </returns>
        VehicleDto Parse(string html);
    }
}
