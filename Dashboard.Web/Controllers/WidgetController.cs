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
    using System;
    using System.Configuration;
    using System.Web.Mvc;

    using AutoMapper;

    using Castle.Components.DictionaryAdapter;

    using Dashboard.Constants;
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
        /// The vehicle 1 make.
        /// </summary>
        private readonly string vehicle1Make = ConfigurationManager.AppSettings[Constants.AppSettings.Vehicle1.Make];

        /// <summary>
        /// The vehicle 1 plate.
        /// </summary>
        private readonly string vehicle1Plate = ConfigurationManager.AppSettings[Constants.AppSettings.Vehicle1.NumberPlate];

        ///// <summary>
        ///// The vehicle 2 make.
        ///// </summary>
        //private readonly string vehicle2Make = ConfigurationManager.AppSettings[Constants.AppSettings.Vehicle2.Make];

        ///// <summary>
        ///// The vehicle 2 plate.
        ///// </summary>
        //private readonly string vehicle2Plate = ConfigurationManager.AppSettings[Constants.AppSettings.Vehicle2.NumberPlate];

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
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult Dvla()
        {
            var dto = this.dvlaService.GetVehicleDetails(this.vehicle1Make, this.vehicle1Plate);

            var viewModel = Mapper.Map<VehicleDto, DvlaWidgetViewModel>(dto);

            return this.PartialView("Widget/_DvlaWidget", viewModel);
        }
    }
}