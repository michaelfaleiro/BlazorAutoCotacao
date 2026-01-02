namespace BlazorAutoCotacao.Dtos.Response;

public class QuoteItemResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Quantity { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public List<SupplierPriceResponse> SupplierPrices { get; set; } = new();
}
