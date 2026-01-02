using BlazorAutoCotacao.Dtos.Request;
using BlazorAutoCotacao.Dtos.Response;
using BlazorAutoCotacao.Services.Interfaces;

namespace BlazorAutoCotacao.Services;

public class QuotesService
{
    private readonly IQuotesApi _quotesApi;

    public QuotesService(IQuotesApi quotesApi)
    {
        _quotesApi = quotesApi;
    }

    public async Task<CreateQuoteDtoResponse> CreateQuoteAsync(CreateQuoteDto request)
    {
        return await _quotesApi.CreateQuoteAsync(request);
    }

    public async Task<GetAllQuotesItemsResponse> GetAllQuotesAsync(
        string? search = null,
        string? vehicleModel = null,
        string? vehicleLicencePlate = null,
        string? vehicleVin = null,
        string? status = null,
        string orderBy = "createdAt",
        int page = 1,
        int pageSize = 25)
    {
        return await _quotesApi.GetAllQuotesAsync(search, vehicleModel, vehicleLicencePlate, vehicleVin, status, orderBy, page, pageSize);
    }

    public async Task<GetQuoteByIdResponse> GetQuoteByIdAsync(Guid id)
    {
        return await _quotesApi.GetQuoteByIdAsync(id);
    }

    public async Task<UpdateQuoteResponse> UpdateQuoteAsync(Guid id, UpdateQuoteDto request)
    {
        return await _quotesApi.UpdateQuoteAsync(id, request);
    }

    public async Task UpdateQuoteStatusAsync(Guid id, UpdateQuoteStatusDto request)
    {
        await _quotesApi.UpdateQuoteStatusAsync(id, request);
    }

    public async Task AddQuoteItemAsync(Guid id, AddQuoteItemDto request)
    {
        await _quotesApi.AddQuoteItemAsync(id, request);
    }

    public async Task UpdateQuoteItemAsync(Guid id, Guid itemId, AddQuoteItemDto request)
    {
        await _quotesApi.UpdateQuoteItemAsync(id, itemId, request);
    }

    public async Task DeleteQuoteItemAsync(Guid id, Guid itemId)
    {
        await _quotesApi.DeleteQuoteItemAsync(id, itemId);
    }

    public async Task AddSupplierPriceAsync(AddSupplierPriceDto request)
    {
        await _quotesApi.AddSupplierPriceAsync(request);
    }

    public async Task UpdateSupplierPriceAsync(Guid id, UpdateSupplierPriceDto request)
    {
        await _quotesApi.UpdateSupplierPriceAsync(id, request);
    }

    public async Task DeleteSupplierPriceAsync(Guid id)
    {
        await _quotesApi.DeleteSupplierPriceAsync(id);
    }

    public async Task SelectWinnerAsync(Guid id)
    {
        await _quotesApi.SelectWinnerAsync(id);
    }

    public async Task<QuoteSummaryResponse> GetQuoteSummaryAsync(Guid id)
    {
        return await _quotesApi.GetQuoteSummaryAsync(id);
    }
}
