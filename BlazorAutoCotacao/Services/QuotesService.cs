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

    public async Task<GetQuoteByIdResponse> GetQuoteByIdAsync(Guid quoteId)
    {
        return await _quotesApi.GetQuoteByIdAsync(quoteId);
    }

    public async Task<UpdateQuoteResponse> UpdateQuoteAsync(UpdateQuoteDto request)
    {
        return await _quotesApi.UpdateQuoteAsync(request);
    }

    public async Task UpdateQuoteStatusAsync(UpdateQuoteStatusDto request)
    {
        await _quotesApi.UpdateQuoteStatusAsync(request);
    }

    public async Task AddQuoteItemAsync(AddQuoteItemDto request)
    {
        await _quotesApi.AddQuoteItemAsync(request);
    }

    public async Task UpdateQuoteItemAsync(UpdateQuoteItemDto request)
    {
        await _quotesApi.UpdateQuoteItemAsync(request);
    }

    public async Task DeleteQuoteItemAsync(Guid id, Guid itemId)
    {
        await _quotesApi.DeleteQuoteItemAsync(id, itemId);
    }

    public async Task AddSupplierPriceAsync(AddSupplierPriceDto request)
    {
        await _quotesApi.AddSupplierPriceAsync(request);
    }

    public async Task UpdateSupplierPriceAsync(UpdateSupplierPriceDto request)
    {
        await _quotesApi.UpdateSupplierPriceAsync(request);
    }

    public async Task DeleteSupplierPriceAsync(Guid id)
    {
        await _quotesApi.DeleteSupplierPriceAsync(id);
    }

    public async Task SelectWinnerAsync(SelectSupplierPriceWinnerCommand request)
    {
        await _quotesApi.SelectWinnerAsync(request);
    }

    public async Task<QuoteSummaryResponse> GetQuoteSummaryAsync(Guid id)
    {
        return await _quotesApi.GetQuoteSummaryAsync(id);
    }

    public async Task<DashboardSavingsResponse> GetDashboardSavingsAsync(DateTime? startDate = null, DateTime? endDate = null)
    {
        return await _quotesApi.GetDashboardSavingsAsync(startDate, endDate);
    }
}
