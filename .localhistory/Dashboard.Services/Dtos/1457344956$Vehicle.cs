// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Vehicle.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the Vehicle type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------



namespace Services.Dtos
{
    using System;

    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string NumberPlate { get; set; }
        public bool Taxed { get; set; }
        public DateTime TaxedUntil { get; set; }
        public bool Mot { get; set; }
        public DateTime MotUntil { get; set; }
    }
}