// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Requirement.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the Requirement type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dashboard.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// The mot.
    /// </summary>
    public class Requirement
    {
        /// <summary>
        /// Gets or sets the requirement id.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RequirementId { get; set; }

        /// <summary>
        /// Gets or sets the expiry date of the requirement.
        /// </summary>
        [Required]
        public DateTime? ExpiryDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the requirement is valid.
        /// </summary>
        [Required]
        public bool IsValid { get; set; }
    }
}
