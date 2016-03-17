// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Requirement.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the Requirement type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dashboard.Services.Dtos
{
    using System;

    /// <summary>
    /// The mot.
    /// </summary>
    public class Requirement
    {
        /// <summary>
        /// Gets or sets the expiry date of the requirement.
        /// </summary>
        public DateTime? ExpiryDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the requirement is valid.
        /// </summary>
        public bool IsValid { get; set; }
    }
}
