// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HttpClient.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the HttpClient type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dashboard.DAL
{
    using System.Net;

    /// <summary>
    /// The http client.
    /// </summary>
    public class HttpClient : IWebClient
    {
        /// <summary>
        /// The make request.
        /// </summary>
        /// <param name="url">
        /// The url.
        /// </param>
        /// <returns>
        /// The <see cref="byte[]"/>.
        /// </returns>
        public byte[] MakeRequest(string url)
        {
            using (var client = new WebClient())
            {
                
            }

            return null;
        }
    }
}
