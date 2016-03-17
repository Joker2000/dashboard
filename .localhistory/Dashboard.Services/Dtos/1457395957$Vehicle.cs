// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Vehicle.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the Vehicle type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dashboard.Services.Dtos
{
    using System;

    /// <summary>
    /// The vehicle.
    /// </summary>
    public class Vehicle
    {
        /// <summary>
        /// Gets or sets the make.
        /// </summary>
        public string Make { get; set; }

        /// <summary>
        /// Gets or sets the model.
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// Gets or sets the number plate.
        /// </summary>
        public string NumberPlate { get; set; }

        /// <summary>
        /// Gets or sets the road tax.
        /// </summary>
        public Requirement RoadTax { get; set; }

        /// <summary>
        /// Gets or sets the mot.
        /// </summary>
        public Requirement Mot { get; set; }

        /// <summary>
        /// Gets or sets the date of first registration.
        /// </summary>
        public DateTime DateOfFirstRegistration { get; set; }

        /// <summary>
        /// Gets or sets the year of manufacture.
        /// </summary>
        public DateTime YearOfManufacture { get; set; }

        /// <summary>
        /// Gets or sets the cynlinder capacity.
        /// </summary>
        public string CynlinderCapacity { get; set; }

        /// <summary>
        /// Gets or sets the co 2 emissions.
        /// </summary>
        public string Co2Emissions { get; set; }


    }
}