// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EmailTests.cs" company="">
//   
// </copyright>
// <summary>
//   The email tests.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dashboard.Tests.Services
{
    using Dashboard.API.Services.Parsers;

    using NUnit.Framework;

    /// <summary>
    /// The email tests.
    /// </summary>
    [TestFixture]
    public class EmailTests
    {
        /// <summary>
        /// The email html parser.
        /// </summary>
        private EmailHtmlParser emailHtmlParser;

        /// <summary>
        /// The set up.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            this.emailHtmlParser = new EmailHtmlParser();
        }

        /// <summary>
        /// The get emails from page.
        /// </summary>
        [Test]
        public void GetEmailsFromPage()
        {
            // Arrange
            var html = new System.Net.WebClient().DownloadString("http://www.influentialsoftware.com/contact-us");

            // Act
            var result = this.emailHtmlParser.Parse(html);
        }
    }
}