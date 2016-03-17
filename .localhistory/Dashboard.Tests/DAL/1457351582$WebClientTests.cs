// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WebClientTests.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the WebClientTests type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dashboard.Tests.DAL
{
    using System;
    using System.Configuration;

    using Dashboard.DAL;

    using NUnit.Framework;

    /// <summary>
    /// The web client tests.
    /// </summary>
    public class WebClientTests
    {
        /// <summary>
        /// The web client.
        /// </summary>
        private IWebClient webClient;

        [SetUp]
        public void SetUp()
        {
            this.webClient = new WebClient();
        }
    }
}
