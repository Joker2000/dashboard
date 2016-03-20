// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DvlaService.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the DvlaService type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dashboard.Web.Services
{
    using System;
    using System.Net;

    using Dashboard.Dto;

    using RestSharp;

    /// <summary>
    /// The DVLA service.
    /// </summary>
    public class DvlaService : IDvlaService
    {
        /// <summary>
        /// The client.
        /// </summary>
        protected readonly IRestClient Client;

        /// <summary>
        /// Initializes a new instance of the <see cref="DvlaService"/> class.
        /// </summary>
        public DvlaService()
        {
            this.Client = new RestClient { BaseUrl = new Uri("http://localhost:56162/api/") };
        }

        /// <summary>
        /// The get vehicle details.
        /// </summary>
        /// <param name="make">
        /// The make.
        /// </param>
        /// <param name="numberPlate">
        /// The number plate.
        /// </param>
        /// <returns>
        /// The <see cref="VehicleDto"/>.
        /// </returns>
        public VehicleDto GetVehicleDetails(string make, string numberPlate)
        {
            var url = $"car?make={make}&numberPlate={numberPlate}";

            try
            {
                var request = new RestRequest(url, Method.GET);

                var response = this.Client.Execute<VehicleDto>(request);

                //this.Logger.Debug(request.Resource + " - " + Constants.Api.StatusCodeReceived + response.StatusCode);

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    return default(VehicleDto);
                }

                var data = response.Data;

                //this.Logger.Debug(string.Format(Constants.Api.SingleReceivedFromApi, data.GetType()));

                return data;
            }
            catch (Exception exception)
            {
                //this.Logger.Error(Constants.Api.ApiCommunicationError, exception);
                return default(VehicleDto);
            }
        }
    }
}
