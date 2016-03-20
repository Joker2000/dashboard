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

    using Dashboard.Dto;
    using Dashboard.Web.Mapping;
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
        public WidgetController()
        {
            this.dvlaService = new DvlaService();
        }

        // GET: Widget
        /// <summary>
        /// The index.
        /// </summary>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult Dvla()
        {
            var dto = this.dvlaService.GetVehicleDetails("Honda", "GJ05ABX");

            var viewModel = AutoMapperServiceConfiguration.Mapper.Map<VehicleDto, DvlaWidgetViewModel>(dto);

            return this.PartialView("Widget/_DvlaWidget", viewModel);
        }
    }
}