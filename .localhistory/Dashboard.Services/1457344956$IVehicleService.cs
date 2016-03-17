// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IVehicleService.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the IVehicleService type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Services
{
    using Services.Dtos;

    /// <summary>
    /// The VehicleService interface.
    /// </summary>
    public interface IVehicleService
    {
        /// <summary>
        /// The get vehicle info.
        /// </summary>
        /// <param name="vehicle">
        /// The vehicle.
        /// </param>
        /// <returns>
        /// The <see cref="Vehicle"/>.
        /// </returns>
        Vehicle GetVehicleInfo(Vehicle vehicle);
    }
}