namespace BlazorAutoCotacao.Models;

public class QuoteItem
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public ICollection<SupplierPrice> SupplierPrices { get; set; } = [];
    public int Quantity { get; set; }
    public string Sku { get; set; } = string.Empty;
    public string Observation { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}