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

    using Dashboard.Data.Web;
    using Dashboard.Dto;
    using Dashboard.Services;
    using Dashboard.Services.Parsers;

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
            var vehicle = this.vehicleService.GetVehicleInfo(new VehicleDto { Make = "Honda", NumberPlate = "GJ05 ABX" });

            var vehicles = new List<VehicleDto> { vehicle };
            
            return vehicles;
        }

        /// <summary>
        /// The get.
        /// </summary>
        /// <param name="vehicle">
        /// The vehicle.
        /// </param>
        /// <returns>
        /// The <see cref="VehicleDto"/>.
        /// </returns>
        //public VehicleDto Get(VehicleDto vehicle)
        //{
        //    return this.vehicleService.GetVehicleInfo(vehicle);
        //}
    }
}