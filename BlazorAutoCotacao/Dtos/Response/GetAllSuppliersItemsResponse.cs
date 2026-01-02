namespace BlazorAutoCotacao.Dtos.Response;

public class GetAllSuppliersItemsResponse
{
    public List<GetAllSuppliersResponse> Data { get; set; } = new();
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
    public int TotalCount { get; set; }
}
