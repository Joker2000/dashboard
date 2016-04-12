// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GitHubController.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the GitHubController type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dashboard.API.Controllers
{
    using System.Web.Http;

    using Dashboard.API.Services.Services;
    using Dashboard.Dto;

    /// <summary>
    /// The git hub controller.
    /// </summary>
    public class GitHubController : ApiController
    {
        /// <summary>
        /// The git hub service.
        /// </summary>
        private readonly IGitHubService gitHubService;

        /// <summary>
        /// Initializes a new instance of the <see cref="GitHubController"/> class.
        /// </summary>
        /// <param name="gitHubService">
        /// The git hub service.
        /// </param>
        public GitHubController(IGitHubService gitHubService)
        {
            this.gitHubService = gitHubService;
        }

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
        public Commit GetLastCommit(string account, string repo)
        {
            var result = this.gitHubService.GetLastCommit(account, repo);

            return null;
        }

        public Commit GetTest()
        {
            var result = this.gitHubService.GetLastCommit("joker2000", "dashboard");

            return null;
        }
    }
}