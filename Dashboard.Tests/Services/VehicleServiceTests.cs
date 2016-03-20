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
    using Dashboard.API.DAL;
    using Dashboard.API.Services;
    using Dashboard.API.Services.Parsers;
    using Dashboard.Dto;

    using NUnit.Framework;

    /// <summary>
    /// The vehicle service tests.
    /// </summary>
    [TestFixture]
    public class VehicleServiceTests
    {
        /// <summary>
        /// The vehicle service.
        /// </summary>
        private IVehicleService vehicleService;

        /// <summary>
        /// The set up.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            this.vehicleService = new VehicleService(new WebClient(), new VehicleHtmlParser());
        }

        /// <summary>
        /// The get Audi info.
        /// </summary>
        [Test]
        public void GetAudiInfo()
        {
            // Arrange
            var vehicle = new VehicleDto { Make = "Audi", NumberPlate = "YD54 UAT" };

            // Act
            var result = this.vehicleService.GetVehicleInfo(vehicle);

            // Assert
        }

        /// <summary>
        /// The get Vauxhall info.
        /// </summary>
        [Test]
        public void GetVauxhallInfo()
        {
            // Arrange
            var vehicle = new VehicleDto { Make = "Vauxhall", NumberPlate = "E903 CMY" };

            // Act
            var result = this.vehicleService.GetVehicleInfo(vehicle);

            // Assert
        }
    }
}
