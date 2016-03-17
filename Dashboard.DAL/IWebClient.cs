// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IWebClient.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the IWebClient type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dashboard.Data.Web
{
    /// <summary>
    /// The WebClient interface.
    /// </summary>
    public interface IWebClient
    {
        /// <summary>
        /// The make vehicle enquiry.
        /// </summary>
        /// <param name="responseBody">
        /// The response body.
        /// </param>
        /// <param name="numberPlate">
        /// The number Plate.
        /// </param>
        /// <param name="manufacturer">
        /// The manufacturer.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        bool MakeVehicleEnquiry(out string responseBody, string numberPlate, string manufacturer);
    }
}
