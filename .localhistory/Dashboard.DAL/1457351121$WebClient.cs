﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HttpClient.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the HttpClient type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dashboard.DAL
{
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading.Tasks;

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
        public async Task<byte[]> MakeRequest(string url)
        {
            var formData = new Dictionary<string, string>();
            formData.Add("number", number);

            var content = new FormUrlEncodedContent(formData);

            using (var httpClient = new HttpClient())
            {
                var httpResponse = await httpClient.PostAsync(theurl, content);

                var responseString = await httpResponse.Content.ReadAsStringAsync();
            }


            using (var client = new WebClient())
            {

                client.DownloadData(url);
            }

            return null;
        }
    }
}
