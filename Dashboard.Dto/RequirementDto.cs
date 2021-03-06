﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RequirementDto.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the RequirementDto type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dashboard.Dto
{
    using System;

    /// <summary>
    /// The mot.
    /// </summary>
    public class RequirementDto
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
