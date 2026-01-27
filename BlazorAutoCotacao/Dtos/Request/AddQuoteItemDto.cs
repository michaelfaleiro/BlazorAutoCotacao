namespace BlazorAutoCotacao.Dtos.Request;

public class AddQuoteItemDto
{
    public Guid QuoteId { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Quantity { get; set; }
    public string Sku { get; set; } = string.Empty;
    public string Observation { get; set; } = string.Empty;
}
