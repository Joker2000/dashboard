// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IVehicleService.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the IVehicleService type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dashboard.API.Services.Services
{
    using Dashboard.Dto;

    /// <summary>
    /// The VehicleService interface.
    /// </summary>
    public interface IVehicleService
    {
        /// <summary>
        /// The get vehicle info.
        /// </summary>
        /// <param name="vehicleDto">
        /// The vehicle DTO info.
        /// </param>
        /// <returns>
        /// The <see cref="VehicleDto"/>.
        /// </returns>
        VehicleDto GetVehicleInfo(VehicleDto vehicleDto);

        /// <summary>
        /// The get vehicle info.
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
        VehicleDto GetVehicleInfo(string make, string numberPlate);
    }
}