// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IGitHubService.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the IGitHubService type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dashboard.API.Services.Services
{
    /// <summary>
    /// The GitHubService interface.
    /// </summary>
    public interface IGitHubService
    {
        /// <summary>
        /// The get last commit.
        /// </summary>
        /// <param name="repo">
        /// The repo.
        /// </param>
        void GetLastCommit(string repo);
    }
}
