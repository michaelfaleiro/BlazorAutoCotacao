namespace BlazorAutoCotacao.Models;

public class Supplier
{
    public Guid Id { get; set; }
    public string LegalName { get; set; } = string.Empty;
    public string FantasyName { get; set; } = string.Empty;
    public string Cnpj { get; set; } = string.Empty;
    
}