namespace BlazorAutoCotacao.Dtos.Response;

public class QuoteItemResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Quantity { get; set; }
    public string Sku { get; set; } = string.Empty;
    public string Observation { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public ICollection<SupplierPriceResponse> SupplierPrices { get; set; } = [];
}
