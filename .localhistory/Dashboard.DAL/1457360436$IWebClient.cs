// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IWebClient.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the IWebClient type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dashboard.DAL
{
    using System.Net;

    /// <summary>
    /// The WebClient interface.
    /// </summary>
    public interface IWebClient
    {
        bool MakeVehicleEnquiry(out HttpWebResponse response);
    }
}
