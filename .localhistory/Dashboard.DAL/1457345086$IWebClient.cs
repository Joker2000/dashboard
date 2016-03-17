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
    /// <summary>
    /// The WebClient interface.
    /// </summary>
    public interface IWebClient
    {
        byte[] MakeRequest(string url);
    }
}
