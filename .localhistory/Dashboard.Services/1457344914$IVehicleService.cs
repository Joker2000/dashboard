namespace Services
{
    using Services.Dtos;

    public interface IVehicleService
    {
        Vehicle GetVehicleInfo(Vehicle vehicle);
    }
}