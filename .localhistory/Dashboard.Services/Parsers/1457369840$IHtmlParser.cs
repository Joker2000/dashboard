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

    interface IHtmlParser
    {
        Vehicle Parse(string html);
    }
}
