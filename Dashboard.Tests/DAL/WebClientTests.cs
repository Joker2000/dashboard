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

    using Dashboard.Data.Web;

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

        /// <summary>
        /// The set up.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            this.webClient = new WebClient();
        }

        /// <summary>
        /// The make dvla request.
        /// </summary>
        [Test]
        public void MakeDvlaRequest()
        {
            // Arrange
            var responseBody = string.Empty;
            this.webClient.MakeVehicleEnquiry(out responseBody, "GJ05ABX", "HONDA");

            // Act

            // Assert

        }
    }
}
