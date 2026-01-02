namespace BlazorAutoCotacao.Dtos.Request;

public class CreateSupplierDto
{
    public string LegalName { get; set; } = string.Empty;
    public string FantasyName { get; set; } = string.Empty;
    public string Cnpj { get; set; } = string.Empty;
}
