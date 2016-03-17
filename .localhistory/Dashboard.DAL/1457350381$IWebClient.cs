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
    /// <typeparam name="TDto">
    /// The DTO Type.
    /// </typeparam>
    public interface IWebClient<TDto>
    {
        /// <summary>
        /// The make request.
        /// </summary>
        /// <param name="url">
        /// The url.
        /// </param>
        /// <param name="dto">
        /// The dto.
        /// </param>
        /// <returns>
        /// The <see cref="byte[]"/>.
        /// </returns>
        byte[] MakeRequest(string url, TDto dto);
    }
}
