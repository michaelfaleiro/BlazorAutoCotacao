namespace BlazorAutoCotacao.Dtos.Response;

public class QuoteItemSummaryDto
{
    public Guid QuoteItemId { get; set; }
    public string ItemName { get; set; } = string.Empty;
    public int Quantity { get; set; }
    public string Brand { get; set; } = string.Empty;
    public decimal UnitPrice { get; set; }
    public decimal TotalPrice { get; set; }
}
