namespace Dashboard.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly IWebClient _client;

        public VehicleService(IWebClient client)
        {
            this._client = client;
        }

        public Vehicle GetVehicleInfo(Vehicle vehicle)
        {
            var response = this._client.MakeRequest("https://www.vehicleenquiry.service.gov.uk");
            var vehicle =
        }
    }
}