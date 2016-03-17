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
        public string NumberPlate { get; set; }
        public bool Taxed { get; set; }
        public DateTime TaxedUntil { get; set; }
        public bool Mot { get; set; }
        public DateTime MotUntil { get; set; }
    }
}