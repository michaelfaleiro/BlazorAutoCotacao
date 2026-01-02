namespace BlazorAutoCotacao.Models
{
    public class Quote
    {
        public Guid Id { get; set; }
        public Vehicle  Vehicle { get; set; } = null!;
        public string Status { get; set; } = string.Empty;
        public ICollection<QuoteItem> QuoteItems { get; set; } = [];
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}