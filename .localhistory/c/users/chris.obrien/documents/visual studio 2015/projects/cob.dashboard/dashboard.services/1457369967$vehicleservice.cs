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
    /// The vehicleInfo service.
    /// </summary>
    public class VehicleService : IVehicleService
    {
        /// <summary>
        /// The client.
        /// </summary>
        private readonly IWebClient client;

        /// <summary>
        /// The vehicleInfo parser.
        /// </summary>
        private readonly IHtmlParser vehicleParser;

        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleService"/> class.
        /// </summary>
        /// <param name="client">
        /// The client.
        /// </param>
        /// <param name="vehicleParser">
        /// The vehicleInfo Parser.
        /// </param>
        public VehicleService(IWebClient client, IHtmlParser vehicleParser)
        {
            this.client = client;
            this.vehicleParser = vehicleParser;
        }

        /// <summary>
        /// The get vehicleInfo info.
        /// </summary>
        /// <param name="vehicleInfo">
        /// The vehicleInfo.
        /// </param>
        /// <returns>
        /// The <see cref="Vehicle"/>.
        /// </returns>
        public Vehicle GetVehicleInfo(Vehicle vehicleInfo)
        {
            string responseBody;
            var success = this.client.MakeVehicleEnquiry(out responseBody);

            var vehicleResults = this.vehicleParser.Parse(responseBody);

            return vehicleResults;
        }
    }
}