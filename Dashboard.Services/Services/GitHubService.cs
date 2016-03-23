// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GitHubService.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the GitHubService type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dashboard.API.Services.Services
{
    using Octokit;

    /// <summary>
    /// The git hub service.
    /// </summary>
    public class GitHubService : IGitHubService
    {
        /// <summary>
        /// The client.
        /// </summary>
        private readonly GitHubClient client;

        public GitHubService(GitHubClient client)
        {
            //this.client = new GitHubClient(new ProductHeaderValue("my-cool-app"));
            this.client = client;
        }

        public GitHubService()
        {
            this.client = new GitHubClient(new ProductHeaderValue("my-cool-app"));
        }

        /// <summary>
        /// The get last commit.
        /// </summary>
        /// <param name="repo">
        /// The repo.
        /// </param>
        public void GetLastCommit(string repo)
        {
            this.client.Repository.Commit.GetAll("joker2000", "dashboard");
        }
    }
}
