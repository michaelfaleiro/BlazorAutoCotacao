namespace BlazorAutoCotacao.Dtos.Request;

public class UpdateQuoteDto
{
    public Guid QuoteId { get; set; }
    public string VehicleModel { get; set; } = string.Empty;
    public string VehicleLicencePlate { get; set; } = string.Empty;
    public string VehicleVin { get; set; } = string.Empty;
    public string VehicleYearModel { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
}
