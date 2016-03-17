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

    public interface IVehicleService
    {
        Vehicle GetVehicleInfo(Vehicle vehicle);
    }
}