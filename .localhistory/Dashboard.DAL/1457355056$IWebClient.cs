﻿// --------------------------------------------------------------------------------------------------------------------
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
        /// The make request.
        /// </summary>
        /// <param name="url">
        /// The url.
        /// </param>
        /// <returns>
        /// The <see cref="byte[]"/>.
        /// </returns>
        Task<byte[]> MakeRequest(string url);

        void MakeRequests();
    }
}
