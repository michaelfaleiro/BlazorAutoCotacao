namespace BlazorAutoCotacao.Dtos.Request;

public class AddSupplierPriceDto
{
    public Guid QuoteId { get; set; }
    public Guid QuoteItemId { get; set; }
    public Guid SupplierId { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public string Brand { get; set; } = string.Empty;
    public string Sku { get; set; } = string.Empty;
    public string Observation { get; set; } = string.Empty;
    public bool IsSelected { get; set; } = false;
}
