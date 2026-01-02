namespace BlazorAutoCotacao.Dtos.Response;

public class QuoteSummaryResponse
{
    public Guid QuoteId { get; set; }
    public string VehicleModel { get; set; } = string.Empty;
    public string VehicleLicencePlate { get; set; } = string.Empty;
    public string VehicleVin { get; set; } = string.Empty;
    public string VehicleYearModel { get; set; } = string.Empty;
    public List<SupplierSummaryDto> Suppliers { get; set; } = new();
    public decimal GrandTotal { get; set; }
}
