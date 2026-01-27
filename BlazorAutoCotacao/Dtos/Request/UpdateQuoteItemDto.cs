namespace BlazorAutoCotacao.Dtos.Request
{
    public class UpdateQuoteItemDto
    {
        public Guid QuoteId { get; set; }
        public Guid ItemId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public string Sku { get; set; } = string.Empty;
        public string Observation { get; set; } = string.Empty;
    }
}