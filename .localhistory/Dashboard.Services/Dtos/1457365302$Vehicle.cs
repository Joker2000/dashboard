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

        public Requirement RoadTax { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether mot.
        /// </summary>
        public bool Mot { get; set; }

        /// <summary>
        /// Gets or sets the mot until.
        /// </summary>
        public DateTime MotUntil { get; set; }
    }
}