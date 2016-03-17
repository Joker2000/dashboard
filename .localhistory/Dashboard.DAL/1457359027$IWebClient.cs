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
    using System.Threading.Tasks;

    /// <summary>
    /// The WebClient interface.
    /// </summary>
    public interface IWebClient
    {
        /// <summary>
        /// The make requests.
        /// </summary>
        void MakeRequests();
    }
}
