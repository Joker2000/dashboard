﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="VehicleDto.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the VehicleDto type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dashboard.Dto
{
    using System;

    /// <summary>
    /// The vehicle.
    /// </summary>
    public class VehicleDto
    {
        /// <summary>
        /// Gets or sets the make.
        /// </summary>
        public string Make { get; set; }

        /// <summary>
        /// Gets or sets the number plate.
        /// </summary>
        public string NumberPlate { get; set; }

        /// <summary>
        /// Gets or sets the road tax.
        /// </summary>
        public RequirementDto RoadTax { get; set; }

        /// <summary>
        /// Gets or sets the mot.
        /// </summary>
        public RequirementDto Mot { get; set; }

        /// <summary>
        /// Gets or sets the date of first registration.
        /// </summary>
        public DateTime DateOfFirstRegistration { get; set; }

        /// <summary>
        /// Gets or sets the year of manufacture.
        /// </summary>
        public int YearOfManufacture { get; set; }

        /// <summary>
        /// Gets or sets the cynlinder capacity.
        /// </summary>
        public string CynlinderCapacity { get; set; }

        /// <summary>
        /// Gets or sets the co 2 emissions.
        /// </summary>
        public string Co2Emissions { get; set; }

        /// <summary>
        /// Gets or sets the fuel type.
        /// </summary>
        public string FuelType { get; set; }

        /// <summary>
        /// Gets or sets the colour.
        /// </summary>
        public string Colour { get; set; }

        /// <summary>
        /// Gets or sets the vehicle type approval.
        /// </summary>
        public string VehicleTypeApproval { get; set; }

        /// <summary>
        /// Gets or sets the wheel plan.
        /// </summary>
        public string Wheelplan { get; set; }

        /// <summary>
        /// Gets or sets the revenue weight.
        /// </summary>
        public string RevenueWeight { get; set; }
    }
}