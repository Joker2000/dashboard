// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IVehicleService.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the IVehicleService type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dashboard.Services
{
    using System.Collections.Generic;

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
        /// <param name="vehicles">
        /// The vehicles.
        /// </param>
        /// <returns>
        /// The <see cref="IEnumerable{VehicleDto}"/>.
        /// </returns>
        IEnumerable<VehicleDto> GetVehicleInfo(IEnumerable<VehicleDto> vehicles);
    }
}