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
    using System.Collections.Generic;
    using System.Linq;

    using Dashboard.Data.Web;
    using Dashboard.Dto;
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

        /// <summary>
        /// The vehicle parser.
        /// </summary>
        private readonly IHtmlParser vehicleParser;

        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleService"/> class.
        /// </summary>
        /// <param name="client">
        /// The client.
        /// </param>
        /// <param name="vehicleParser">
        /// The vehicle parser.
        /// </param>
        public VehicleService(IWebClient client, IHtmlParser vehicleParser)
        {
            this.client = client;
            this.vehicleParser = vehicleParser;
        }

        /// <summary>
        /// The get vehicle info.
        /// </summary>
        /// <param name="vehicleDto">
        /// The vehicle DTO info.
        /// </param>
        /// <returns>
        /// The <see cref="VehicleDto"/>.
        /// </returns>
        public VehicleDto GetVehicleInfo(VehicleDto vehicleDto)
        {
            return this.MakeEnquiry(vehicleDto);
        }

        /// <summary>
        /// The get vehicle info.
        /// </summary>
        /// <param name="vehicles">
        /// The vehicles.
        /// </param>
        /// <returns>
        /// The <see cref="IEnumerable{VehicleDto}"/>.
        /// </returns>
        public IEnumerable<VehicleDto> GetVehicleInfo(IEnumerable<VehicleDto> vehicles)
        {
            return vehicles.Select(this.MakeEnquiry);
        }

        /// <summary>
        /// The make enquiry.
        /// </summary>
        /// <param name="vehicleDto">
        /// The vehicle DTO.
        /// </param>
        /// <returns>
        /// The <see cref="VehicleDto"/>.
        /// </returns>
        private VehicleDto MakeEnquiry(VehicleDto vehicleDto)
        {
            string responseBody;
            return this.client.MakeVehicleEnquiry(out responseBody, vehicleDto.NumberPlate, vehicleDto.Make)
                       ? this.vehicleParser.Parse(responseBody)
                       : new VehicleDto();
        }
    }
}