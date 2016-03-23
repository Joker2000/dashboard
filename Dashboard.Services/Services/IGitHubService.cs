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
    using Octokit;

    /// <summary>
    /// The GitHubService interface.
    /// </summary>
    public interface IGitHubService
    {
        /// <summary>
        /// The get last commit.
        /// </summary>
        /// <param name="account">
        /// The account.
        /// </param>
        /// <param name="repo">
        /// The repo.
        /// </param>
        /// <returns>
        /// The <see cref="Commit"/>.
        /// </returns>
        Commit GetLastCommit(string account, string repo);
    }
}
