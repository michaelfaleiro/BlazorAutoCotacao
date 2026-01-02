namespace BlazorAutoCotacao.Dtos.Response;

public class GetAllQuotesItemsResponse
{
    public List<GetAllQuotesResponse> Data { get; set; } = new();
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
    public int TotalCount { get; set; }
}
