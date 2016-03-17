﻿// --------------------------------------------------------------------------------------------------------------------
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
    using Dashboard.Services.Dtos;
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

        [Test]
        public void RunGetVehicleInfo()
        {
            // Arrange
            var vehicle = new Vehicle
                              {
                                  Make = "Honda",
                                  NumberPlate = "GJ05 ABX"
                              };

            // Act
            var result = this.vehicleService.GetVehicleInfo(vehicle);

            // Assert

        }
    }
}
