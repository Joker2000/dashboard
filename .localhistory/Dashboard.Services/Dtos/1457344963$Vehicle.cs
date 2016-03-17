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
        /// Gets or sets a value indicating whether taxed.
        /// </summary>
        public bool Taxed { get; set; }

        /// <summary>
        /// Gets or sets the taxed until.
        /// </summary>
        public DateTime TaxedUntil { get; set; }
        public bool Mot { get; set; }
        public DateTime MotUntil { get; set; }
    }
}