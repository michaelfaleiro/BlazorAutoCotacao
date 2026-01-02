namespace BlazorAutoCotacao.Models;

public class Vehicle
{
    public Guid Id { get; set; }
    public string VehicleModel { get; set; } = string.Empty;
    public string VehicleLicencePlate { get; set; } = string.Empty;
    public string VehicleVin { get; set; } = string.Empty;
    public string VehicleYearModel { get; set; } = string.Empty;
}
