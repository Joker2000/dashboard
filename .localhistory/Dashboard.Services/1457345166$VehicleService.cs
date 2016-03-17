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
    using Dashboard.DAL;
    using Dashboard.Services.Dtos;

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
        /// Initializes a new instance of the <see cref="VehicleService"/> class.
        /// </summary>
        /// <param name="client">
        /// The client.
        /// </param>
        public VehicleService(IWebClient client)
        {
            this.client = client;
        }

        public Vehicle GetVehicleInfo(Vehicle vehicle)
        {
            var response = this.client.MakeRequest("https://www.vehicleenquiry.service.gov.uk");
            //var vehicle =

            return null;
        }
    }
}