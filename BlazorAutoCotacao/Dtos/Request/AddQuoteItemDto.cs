namespace BlazorAutoCotacao.Dtos.Request;

public class AddQuoteItemDto
{
    public Guid QuoteId { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Quantity { get; set; }
}
