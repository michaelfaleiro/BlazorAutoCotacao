namespace BlazorAutoCotacao.Dtos.Request;

public class UpdateSupplierPriceDto
{
    public Guid SupplierPriceId { get; set; }
    public decimal Price { get; set; }
    public string Brand { get; set; } = string.Empty;
    public int Quantity { get; set; }
    public bool IsSelected { get; set; }
}
