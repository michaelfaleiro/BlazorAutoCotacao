namespace BlazorAutoCotacao.Dtos.Request;

public class UpdateSupplierPriceDto
{
    public Guid SupplierPriceId { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public string Brand { get; set; } = string.Empty;
    public string Sku { get; set; } = string.Empty;
    public string Observation { get; set; } = string.Empty;
    public bool IsSelected { get; set; }
}
