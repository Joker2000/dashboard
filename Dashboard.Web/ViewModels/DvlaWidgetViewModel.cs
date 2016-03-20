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
    using Dashboard.Dto;

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
        public RequirementDto RoadTax { get; set; }

        /// <summary>
        /// Gets or sets the mot.
        /// </summary>
        public RequirementDto Mot { get; set; }
    }
}