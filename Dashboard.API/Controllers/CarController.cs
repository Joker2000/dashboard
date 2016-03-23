// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CarController.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the CarController type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dashboard.API.Controllers
{
    using System.Collections.Generic;
    using System.Web.Http;

    using Dashboard.API.DAL;
    using Dashboard.API.Services;
    using Dashboard.API.Services.Parsers;
    using Dashboard.API.Services.Services;
    using Dashboard.Dto;

    /// <summary>
    /// The car controller.
    /// </summary>
    public class CarController : ApiController
    {
        /// <summary>
        /// The vehicle service.
        /// </summary>
        private readonly IVehicleService vehicleService;
        
        /// <summary>
        /// Initializes a new instance of the <see cref="CarController"/> class.
        /// </summary>
        public CarController()
        {
            this.vehicleService = new VehicleService(new WebClient(), new VehicleHtmlParser());
        }

        /// <summary>
        /// The get.
        /// </summary>
        /// <returns>
        /// The <see cref="IEnumerable{VehicleDto}"/>.
        /// </returns>
        public IEnumerable<VehicleDto> Get()
        {
            var vehicle = this.vehicleService.GetVehicleInfo(new VehicleDto { Make = "Audi", NumberPlate = "YD54 UAT" });

            var vehicles = new List<VehicleDto> { vehicle };
            
            return vehicles;
        }

        /// <summary>
        /// The get.
        /// </summary>
        /// <param name="make">
        /// The make.
        /// </param>
        /// <param name="numberPlate">
        /// The number Plate.
        /// </param>
        /// <returns>
        /// The <see cref="VehicleDto"/>.
        /// </returns>
        [HttpGet]
        public VehicleDto Get(string make, string numberPlate)
        {
            var vehicle = this.vehicleService.GetVehicleInfo(make, numberPlate);
            return vehicle;
        }
    }
}