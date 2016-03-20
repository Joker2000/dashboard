// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDvlaService.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the IDvlaService type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dashboard.Web.Services
{
    using Dashboard.Dto;

    /// <summary>
    /// The DVLA Service interface.
    /// </summary>
    public interface IDvlaService
    {
        /// <summary>
        /// Gets the vehicle details.
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
        VehicleDto GetVehicleDetails(string make, string numberPlate);
    }
}
