namespace BlazorAutoCotacao.Dtos.Response;

public class SupplierSummaryDto
{
    public Guid SupplierId { get; set; }
    public string SupplierFantasyName { get; set; } = string.Empty;
    public List<QuoteItemSummaryDto> Items { get; set; } = new();
    public decimal TotalPrice { get; set; }
}
