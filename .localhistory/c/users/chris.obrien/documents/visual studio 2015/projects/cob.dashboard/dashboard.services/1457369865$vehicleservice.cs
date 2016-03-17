// --------------------------------------------------------------------------------------------------------------------
// <copyright file="VehicleService.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the VehicleService type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dashboard.Services
{
    using AutoMapper;

    using Dashboard.DAL;
    using Dashboard.Services.Dtos;
    using Dashboard.Services.Parsers;

    /// <summary>
    /// The vehicle service.
    /// </summary>
    public class VehicleService : IVehicleService
    {
        /// <summary>
        /// The client.
        /// </summary>
        private readonly IWebClient client;

        private readonly IHtmlParser vehicleParser;

        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleService"/> class.
        /// </summary>
        /// <param name="client">
        /// The client.
        /// </param>
        public VehicleService(IWebClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// The get vehicle info.
        /// </summary>
        /// <param name="vehicle">
        /// The vehicle.
        /// </param>
        /// <returns>
        /// The <see cref="Vehicle"/>.
        /// </returns>
        public Vehicle GetVehicleInfo(Vehicle vehicle)
        {
            var responseBody = string.Empty;
            var success = this.client.MakeVehicleEnquiry(out responseBody);
            
            return vehicle;
        }
    }
}