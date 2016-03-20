using System;

namespace Dashboard.Web.ViewModels
{
    public class RequirementViewModel
    {
        /// <summary>
        /// Gets or sets the expiry date of the requirement.
        /// </summary>
        public DateTime? ExpiryDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the requirement is valid.
        /// </summary>
        public bool IsValid { get; set; }

        public double DaysToGo => Math.Round((this.ExpiryDate.Value - DateTime.Now).TotalDays, 0);

        public bool IsDue => this.DaysToGo <= 30;
    }
}