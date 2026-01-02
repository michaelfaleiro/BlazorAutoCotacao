using BlazorAutoCotacao.Dtos.Request;
using BlazorAutoCotacao.Dtos.Response;
using Refit;

namespace BlazorAutoCotacao.Services.Interfaces;

public interface IQuotesApi
{
    [Post("/api/quotes")]
    Task<CreateQuoteDtoResponse> CreateQuoteAsync([Body] CreateQuoteDto request);

    [Get("/api/quotes")]
    Task<GetAllQuotesItemsResponse> GetAllQuotesAsync(
        [Query] string? search = null,
        [Query] string? vehicleModel = null,
        [Query] string? vehicleLicencePlate = null,
        [Query] string? vehicleVin = null,
        [Query] string? status = null,
        [Query] string orderBy = "createdAt",
        [Query] int page = 1,
        [Query] int pageSize = 25);

    [Get("/api/quotes/{id}")]
    Task<GetQuoteByIdResponse> GetQuoteByIdAsync(Guid id);

    [Put("/api/quotes/{id}")]
    Task<UpdateQuoteResponse> UpdateQuoteAsync(Guid id, [Body] UpdateQuoteDto request);

    [Patch("/api/quotes/{id}/status")]
    Task UpdateQuoteStatusAsync(Guid id, [Body] UpdateQuoteStatusDto request);

    [Post("/api/quotes/{id}/items")]
    Task AddQuoteItemAsync(Guid id, [Body] AddQuoteItemDto request);

    [Put("/api/quotes/{id}/items/{itemId}")]
    Task UpdateQuoteItemAsync(Guid id, Guid itemId, [Body] AddQuoteItemDto request);

    [Delete("/api/quotes/{id}/items/{itemId}")]
    Task DeleteQuoteItemAsync(Guid id, Guid itemId);

    [Post("/api/quotes/supplierPrices")]
    Task AddSupplierPriceAsync([Body] AddSupplierPriceDto request);

    [Put("/api/quotes/supplierPrices/{id}")]
    Task UpdateSupplierPriceAsync(Guid id, [Body] UpdateSupplierPriceDto request);

    [Delete("/api/quotes/supplierPrices/{id}")]
    Task DeleteSupplierPriceAsync(Guid id);

    [Patch("/api/quotes/supplierPrices/{id}/select-winner")]
    Task SelectWinnerAsync(Guid id);

    [Get("/api/quotes/{id}/summary")]
    Task<QuoteSummaryResponse> GetQuoteSummaryAsync(Guid id);
}
