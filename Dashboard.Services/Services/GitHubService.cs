﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GitHubService.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the GitHubService type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dashboard.API.Services.Services
{
    using System;

    using System.Collections.Generic;
    using System.Linq;

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

        /// <summary>
        /// Initializes a new instance of the <see cref="GitHubService"/> class.
        /// </summary>
        /// <param name="client">
        /// The client.
        /// </param>
        public GitHubService(GitHubClient client)
        {
            //this.client = new GitHubClient(new ProductHeaderValue("my-cool-app"));
            this.client = client;
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
            var commits = this.client.Repository.Commit.GetAll(account, repo).Result;
            var lastCommit = commits.OrderByDescending(x => x.Commit.Author.Date).First();
            return null;
        }
    }
}
