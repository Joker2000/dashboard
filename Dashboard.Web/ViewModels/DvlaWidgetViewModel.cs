// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DvlaWidgetViewModel.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the DvlaWidgetViewModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dashboard.Web.ViewModels
{
    /// <summary>
    /// The DVLA Widget view model.
    /// </summary>
    public class DvlaWidgetViewModel
    {
        /// <summary>
        /// Gets or sets the make.
        /// </summary>
        public string Make { get; set; }

        /// <summary>
        /// Gets or sets the number plate.
        /// </summary>
        public string NumberPlate { get; set; }

        /// <summary>
        /// Gets or sets the road tax.
        /// </summary>
        public RequirementViewModel RoadTax { get; set; }

        /// <summary>
        /// Gets or sets the mot.
        /// </summary>
        public RequirementViewModel Mot { get; set; }

        /// <summary>
        /// Gets a value indicating whether is due requirement.
        /// </summary>
        public bool IsDueRequirement => this.RoadTax.IsDue || this.Mot.IsDue;
    }
}