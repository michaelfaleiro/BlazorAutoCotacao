namespace BlazorAutoCotacao.Models;

public class SupplierPrice
{
    public Guid Id { get; set; }
    public Guid QuoteItemId { get; set; }
    public Supplier Supplier { get; set; } = null!;
    public decimal Price { get; set; }
    public bool IsSelected { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}