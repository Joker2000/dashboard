// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Vehicle.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the Vehicle type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dashboard.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// The vehicle.
    /// </summary>
    public class Vehicle
    {
        /// <summary>
        /// Gets or sets the vehicle id.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the make.
        /// </summary>
        [Required]
        public string Make { get; set; }

        /// <summary>
        /// Gets or sets the number plate.
        /// </summary>
        [Required]
        public string NumberPlate { get; set; }

        /// <summary>
        /// Gets or sets the road tax id.
        /// </summary>
        [ForeignKey("Requirement")]
        public int RoadTaxId { get; set; }

        /// <summary>
        /// Gets or sets the road tax.
        /// </summary>
        public virtual Requirement RoadTax { get; set; }

        /// <summary>
        /// Gets or sets the mot id.
        /// </summary>
        [ForeignKey("Requirement")]
        public int MotId { get; set; }

        /// <summary>
        /// Gets or sets the mot.
        /// </summary>
        public virtual Requirement Mot { get; set; }

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

        /// <summary>
        /// Gets or sets the created.
        /// </summary>
        [Required]
        public DateTime CreatedOn { get; set; }
    }
}
