namespace BlazorAutoCotacao.Dtos.Response;

public class GetQuoteByIdResponse
{
    public Guid Id { get; set; }
    public string VehicleModel { get; set; } = string.Empty;
    public string VehicleLicencePlate { get; set; } = string.Empty;
    public string VehicleVin { get; set; } = string.Empty;
    public string VehicleYearModel { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public List<QuoteItemResponse> QuoteItems { get; set; } = new();
}
