// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WebClient.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the WebClient type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dashboard.DAL
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;

    /// <summary>
    /// The http client.
    /// </summary>
    public class WebClient : IWebClient
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
        public Task<byte[]> MakeRequest(string url)
        {
            var formData = new Dictionary<string, string>();
            formData.Add("ctl00$MainContent$txtSearchVrm", "gj05abx");
            formData.Add("ctl00$MainContent$MakeTextBox", "honda");
            formData.Add("__EVENTTARGET:", "");
            formData.Add("__EVENTARGUMENT", "/wEPDwUKMTQ2ODczMjQwMA8WAh4NU2VydmljZUhlYWRlcjL8BAABAAAA/////wEAAAAAAAAADAIAAABBRG1zIFNoYXJlZCwgVmVyc2lvbj0xLjAuMC4wLCBDdWx0dXJlPW5ldXRyYWwsIFB1YmxpY0tleVRva2VuPW51bGwFAQAAACVEbXNTaGFyZWQuRGF0YUNvbnRyYWN0cy5Db21tb24uSGVhZGVyCQAAABNjb252ZXJzYXRpb25JZEZpZWxkD29yaWdpbkRhdGVGaWVsZBJhcHBsaWNhdGlvbkNERmllbGQOY2hhbm5lbENERmllbGQOY29udGFjdElkRmllbGQNZXZlbnRGbGdGaWVsZBJzZXJ2aWNlVHlwZUNERmllbGQPbGFuZ3VhZ2VDREZpZWxkDGVuZFVzZXJGaWVsZAEAAQEAAAQEBA0JAS5EbXNTaGFyZWQuRGF0YUNvbnRyYWN0cy5Db21tb24uU2VydmljZVR5cGVDb2RlAgAAACtEbXNTaGFyZWQuRGF0YUNvbnRyYWN0cy5Db21tb24uTGFuZ3VhZ2VDb2RlAgAAACZEbXNTaGFyZWQuRGF0YUNvbnRyYWN0cy5Db21tb24uRW5kVXNlcgIAAAACAAAACsUnFzN8RtNIBgMAAAALRVZMX1NjcmVlbnMGBAAAAAhEVkxBX1dFQjQGs1AAAAAAAQX7////LkRtc1NoYXJlZC5EYXRhQ29udHJhY3RzLkNvbW1vbi5TZXJ2aWNlVHlwZUNvZGUBAAAAB3ZhbHVlX18ACAIAAAACAAAABfr///8rRG1zU2hhcmVkLkRhdGFDb250cmFjdHMuQ29tbW9uLkxhbmd1YWdlQ29kZQEAAAAHdmFsdWVfXwAIAgAAAAAAAAAKCxYCZg9kFgICAQ9kFgJmDxYCHgRUZXh0BQ9WZWhpY2xlIGVucXVpcnlkGAEFIWN0bDAwJE1haW5Db250ZW50JG12VmVoaWNsZVNlYXJjaA8PZGZkOMP4e5xM56zIBlhi2XMewhlNQTc=");
            formData.Add("__VIEWSTATEGENERATOR", "CA0B0334");
            formData.Add("__EVENTVALIDATION", "/wEdAAd0IcHhxEa4uWyRyzjR7rnhBOwywjxOOgpEYFN2beEgnftoCCZcWJSqSRLD/FKuxxkI0x5r4gPeKgWgSNWptTEWInv2PXI3Jzdn3U6eHDG4Qb7lltCXTdtnDbitYujbDJI0GQSIMiv32DreL6oRbYpQMOLsHH6G6WenImaROqv74B1R+uM=");
            formData.Add("ctl00$MainContent$txtV5CDocumentReferenceNumber", "");
            formData.Add("ctl00$MainContent$butSearch", "Search");

            var content = new FormUrlEncodedContent(formData);

            using (var httpClient = new HttpClient())
            {
                var httpResponse = httpClient.PostAsync(url, content).Result;

                var responseString = httpResponse.Content.ReadAsStringAsync();
            }
            
            return null;
        }
    }
}
