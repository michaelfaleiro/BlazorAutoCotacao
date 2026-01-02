namespace BlazorAutoCotacao.Dtos.Response;

public class SupplierPriceResponse
{
    public Guid Id { get; set; }
    public decimal Price { get; set; }
    public string Brand { get; set; } = string.Empty;
    public int Quantity { get; set; }
    public bool IsSelected { get; set; }
    public SupplierInfoResponse Supplier { get; set; } = new();
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}
