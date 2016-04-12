// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WidgetController.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the WidgetController type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dashboard.Web.Controllers
{
    using System.Web.Mvc;

    using AutoMapper;

    using Dashboard.Dto;
    using Dashboard.Web.Services;
    using Dashboard.Web.ViewModels;

    /// <summary>
    /// The widget controller.
    /// </summary>
    public class WidgetController : Controller
    {
        /// <summary>
        /// The DVLA service.
        /// </summary>
        private readonly IDvlaService dvlaService;

        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetController"/> class.
        /// </summary>
        /// <param name="dvlaService">
        /// The dvla service.
        /// </param>
        public WidgetController(IDvlaService dvlaService)
        {
            this.dvlaService = dvlaService;
        }

        // GET: Widget
        /// <summary>
        /// The index.
        /// </summary>
        /// <param name="make">
        /// The make.
        /// </param>
        /// <param name="numberPlate">
        /// The number Plate.
        /// </param>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult Dvla(string make, string numberPlate)
        {
            var dto = this.dvlaService.GetVehicleDetails(make, numberPlate);

            var viewModel = Mapper.Map<VehicleDto, DvlaWidgetViewModel>(dto);

            return this.PartialView("Widget/_DvlaWidget", viewModel);
        }
    }
}