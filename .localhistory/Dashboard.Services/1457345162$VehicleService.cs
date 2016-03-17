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

    public class VehicleService : IVehicleService
    {
        private readonly IWebClient client;

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