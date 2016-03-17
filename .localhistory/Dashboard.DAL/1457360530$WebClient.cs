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
    using System;
    using System.IO;
    using System.Net;

    /// <summary>
    /// The http client.
    /// </summary>
    public class WebClient : IWebClient
    {
        private const string Body = @"__EVENTTARGET=&__EVENTARGUMENT=&__VIEWSTATE=%2FwEPDwUKMTQ2ODczMjQwMA8WAh4NU2VydmljZUhlYWRlcjL8BAABAAAA%2F%2F%2F%2F%2FwEAAAAAAAAADAIAAABBRG1zIFNoYXJlZCwgVmVyc2lvbj0xLjAuMC4wLCBDdWx0dXJlPW5ldXRyYWwsIFB1YmxpY0tleVRva2VuPW51bGwFAQAAACVEbXNTaGFyZWQuRGF0YUNvbnRyYWN0cy5Db21tb24uSGVhZGVyCQAAABNjb252ZXJzYXRpb25JZEZpZWxkD29yaWdpbkRhdGVGaWVsZBJhcHBsaWNhdGlvbkNERmllbGQOY2hhbm5lbENERmllbGQOY29udGFjdElkRmllbGQNZXZlbnRGbGdGaWVsZBJzZXJ2aWNlVHlwZUNERmllbGQPbGFuZ3VhZ2VDREZpZWxkDGVuZFVzZXJGaWVsZAEAAQEAAAQEBA0JAS5EbXNTaGFyZWQuRGF0YUNvbnRyYWN0cy5Db21tb24uU2VydmljZVR5cGVDb2RlAgAAACtEbXNTaGFyZWQuRGF0YUNvbnRyYWN0cy5Db21tb24uTGFuZ3VhZ2VDb2RlAgAAACZEbXNTaGFyZWQuRGF0YUNvbnRyYWN0cy5Db21tb24uRW5kVXNlcgIAAAACAAAACsUnFzN8RtNIBgMAAAALRVZMX1NjcmVlbnMGBAAAAAhEVkxBX1dFQjQGs1AAAAAAAQX7%2F%2F%2F%2FLkRtc1NoYXJlZC5EYXRhQ29udHJhY3RzLkNvbW1vbi5TZXJ2aWNlVHlwZUNvZGUBAAAAB3ZhbHVlX18ACAIAAAACAAAABfr%2F%2F%2F8rRG1zU2hhcmVkLkRhdGFDb250cmFjdHMuQ29tbW9uLkxhbmd1YWdlQ29kZQEAAAAHdmFsdWVfXwAIAgAAAAAAAAAKCxYCZg9kFgICAQ9kFgJmDxYCHgRUZXh0BQ9WZWhpY2xlIGVucXVpcnlkGAEFIWN0bDAwJE1haW5Db250ZW50JG12VmVoaWNsZVNlYXJjaA8PZGZkOMP4e5xM56zIBlhi2XMewhlNQTc%3D&__VIEWSTATEGENERATOR=CA0B0334&__EVENTVALIDATION=%2FwEdAAd0IcHhxEa4uWyRyzjR7rnhBOwywjxOOgpEYFN2beEgnftoCCZcWJSqSRLD%2FFKuxxkI0x5r4gPeKgWgSNWptTEWInv2PXI3Jzdn3U6eHDG4Qb7lltCXTdtnDbitYujbDJI0GQSIMiv32DreL6oRbYpQMOLsHH6G6WenImaROqv74B1R%2BuM%3D&ctl00%24MainContent%24txtSearchVrm=gj05abx&ctl00%24MainContent%24MakeTextBox=honda&ctl00%24MainContent%24txtV5CDocumentReferenceNumber=&ctl00%24MainContent%24butSearch=Search";

        public string MakeRequests()
        {
            string response;

            if (MakeVehicleEnquiry(out response))
            {
                return response;
            }

            return string.Empty;
        }

        private bool MakeVehicleEnquiry(out string responseBody)
        {
            HttpWebResponse response = null;
            responseBody = string.Empty;

            try
            {
                var request = BuildVehicleRequest();

                var postBytes = System.Text.Encoding.UTF8.GetBytes(Body);
                request.ContentLength = postBytes.Length;
                var stream = request.GetRequestStream();
                stream.Write(postBytes, 0, postBytes.Length);
                stream.Close();

                response = (HttpWebResponse)request.GetResponse();
                var responseStream = response.GetResponseStream();

                if (responseStream != null)
                {
                    var responseReader = new StreamReader(responseStream);
                    responseBody = responseReader.ReadToEnd();
                }
            }
            catch (WebException e)
            {
                if (e.Status == WebExceptionStatus.ProtocolError)
                {
                    response = (HttpWebResponse)e.Response;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                response?.Close();
                return false;
            }

            return true;
        }

        private static HttpWebRequest BuildVehicleRequest()
        {
            var request = (HttpWebRequest)WebRequest.Create("https://www.vehicleenquiry.service.gov.uk/");

            request.KeepAlive = true;
            request.Headers.Set(HttpRequestHeader.Pragma, "no-cache");
            request.Headers.Set(HttpRequestHeader.CacheControl, "no-cache");
            request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
            request.Headers.Add("Origin", @"https://www.vehicleenquiry.service.gov.uk");
            request.Headers.Add("Upgrade-Insecure-Requests", @"1");
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/47.0.2526.106 Safari/537.36";
            request.ContentType = "application/x-www-form-urlencoded";
            request.Headers.Add("DNT", @"1");
            request.Referer = "https://www.vehicleenquiry.service.gov.uk/";
            request.Headers.Set(HttpRequestHeader.AcceptEncoding, "gzip, deflate");
            request.Headers.Set(HttpRequestHeader.AcceptLanguage, "en-GB,en-US;q=0.8,en;q=0.6");
            request.Headers.Set(HttpRequestHeader.Cookie, @"EVL=route=MA==; __cfduid=d2f726367b76cf991e17e9fc2b597039a1457350352; seen_cookie_message=yes; routeData=contact=MTM1NDAxNDY3OA==; _ga=GA1.4.1756999024.1457350484; _gat=1; aaaaaaaaaaaaaaa=JGFDJIDNHNLENPNBDMLJDDFELHAFICFHIJGJHOLGJPDCDALCPKONHLIEFGOANBIDDMLGMJIEGEIKMILPAMGHIEPELKMMEMBBLIJMENMPKPLIEIJGIGFFKBKFJPGCOBNO");

            request.Method = "POST";
            request.ServicePoint.Expect100Continue = false;
            return request;
        }
    }
}
