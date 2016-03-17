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
    using Dashboard.Data.Web;
    using Dashboard.Dto;
    using Dashboard.Services;
    using Dashboard.Services.Parsers;

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
        /// The get Madza info.
        /// </summary>
        [Test]
        public void GetMadzaInfo()
        {
            // Arrange
            var vehicle = new VehicleDto { Make = "Mazda", NumberPlate = "LV58 EGU" };
            
            // Act
            var result = this.vehicleService.GetVehicleInfo(vehicle);

            // Assert
        }

        /// <summary>
        /// The get honda info.
        /// </summary>
        [Test]
        public void GetHondaInfo()
        {
            // Arrange
            var vehicle = new VehicleDto { Make = "Honda", NumberPlate = "GJ05 ABX" };

            // Act
            var result = this.vehicleService.GetVehicleInfo(vehicle);

            // Assert
        }
    }
}
