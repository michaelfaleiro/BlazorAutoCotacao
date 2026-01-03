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

    [Get("/api/quotes/{quoteId}")]
    Task<GetQuoteByIdResponse> GetQuoteByIdAsync([AliasAs("quoteId")] Guid quoteId);

    [Put("/api/quotes")]
    Task<UpdateQuoteResponse> UpdateQuoteAsync([Body] UpdateQuoteDto request);

    [Patch("/api/quotes/status")]
    Task UpdateQuoteStatusAsync([Body] UpdateQuoteStatusDto request);

    [Post("/api/quotes/items")]
    Task AddQuoteItemAsync([Body] AddQuoteItemDto request);

    [Put("/api/quotes/items")]
    Task UpdateQuoteItemAsync([Body] UpdateQuoteItemDto request);

    [Delete("/api/quotes/{id}/items/{itemId}")]
    Task DeleteQuoteItemAsync(Guid id, Guid itemId); // Mantido pois OpenAPI ainda usa path para delete

    [Post("/api/quotes/supplierPrices")]
    Task AddSupplierPriceAsync([Body] AddSupplierPriceDto request);

    [Put("/api/quotes/supplierPrices")]
    Task UpdateSupplierPriceAsync([Body] UpdateSupplierPriceDto request);

    [Delete("/api/quotes/supplierPrices/{id}")]
    Task DeleteSupplierPriceAsync(Guid id); // Mantido pois OpenAPI ainda usa path para delete

    [Patch("/api/quotes/supplierPrices/select-winner")]
    Task SelectWinnerAsync([Body] SelectSupplierPriceWinnerCommand request);

    [Get("/api/quotes/{id}/summary")]
    Task<QuoteSummaryResponse> GetQuoteSummaryAsync(Guid id); // Mantido pois OpenAPI ainda usa path para summary
}
