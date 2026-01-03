namespace BlazorAutoCotacao.Dtos.Request;

public class UpdateQuoteStatusDto
{
    public Guid QuoteId { get; set; }
    public string Status { get; set; } = string.Empty;
}
