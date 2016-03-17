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
