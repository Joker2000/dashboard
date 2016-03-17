// --------------------------------------------------------------------------------------------------------------------
// <copyright file="VehicleServiceTests.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the VehicleServiceTests type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dashboard.Tests.Services
{
    using Dashboard.DAL;
    using Dashboard.Services;
    using Dashboard.Services.Parsers;

    using NUnit.Framework;

    /// <summary>
    /// The vehicle service tests.
    /// </summary>
    [
    
    [TestFixture]
    public class VehicleServiceTests
    {
        private IVehicleService vehicleService;

        [SetUp]
        public void SetUp()
        {
            this.vehicleService = new VehicleService(new WebClient(), new VehicleHtmlParser());
        }

        [Test]
        public void RunGetVehicleInfo()
        {
            // Arrange
            
            // Act

            // Assert

        }
    }
}
