namespace BlazorAutoCotacao.Dtos.Response;

public class DashboardSavingsResponse
{
    public decimal TotalSavings { get; set; }
    public decimal TotalSavingsPercentage { get; set; }
    public decimal TotalQuoteValue { get; set; }
    public int TotalQuotes { get; set; }
    public DateTime PeriodStart { get; set; }
    public DateTime PeriodEnd { get; set; }
    public List<QuoteDetailDto> QuoteDetails { get; set; } = new();
}

public class QuoteDetailDto
{
    public Guid QuoteId { get; set; }
    public string VehicleModel { get; set; } = string.Empty;
    public string VehicleLicencePlate { get; set; } = string.Empty;
    public decimal QuoteTotal { get; set; }
    public decimal Savings { get; set; }
    public decimal SavingsPercentage { get; set; }
    public DateTime CreatedAt { get; set; }
}
