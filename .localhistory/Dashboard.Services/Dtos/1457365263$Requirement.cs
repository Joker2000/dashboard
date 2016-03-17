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
        /// Gets or sets the expiry date.
        /// </summary>
        public DateTime ExpiryDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether is valid.
        /// </summary>
        public bool IsValid { get; set; }
    }
}
