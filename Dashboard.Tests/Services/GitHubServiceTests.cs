// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GitHubServiceTests.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the GitHubServiceTests type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dashboard.Tests.Services
{
    using Dashboard.API.Services.Services;

    using NUnit.Framework;

    using Octokit;

    /// <summary>
    /// The GitHub service tests.
    /// </summary>
    [TestFixture]
    public class GitHubServiceTests
    {
        /// <summary>
        /// The GitHub service.
        /// </summary>
        private IGitHubService gitHubService;

        /// <summary>
        /// The set up.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            this.gitHubService = new GitHubService(new GitHubClient(new ProductHeaderValue("dashboard")));
        }

        /// <summary>
        /// The get last commit.
        /// </summary>
        [Test]
        public void GetLastCommit()
        {
            var commit = this.gitHubService.GetLastCommit("joker2000", "dashboard");
        }
    }
}
