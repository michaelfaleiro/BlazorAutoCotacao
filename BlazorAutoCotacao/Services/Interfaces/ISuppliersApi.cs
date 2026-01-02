using BlazorAutoCotacao.Dtos.Request;
using BlazorAutoCotacao.Dtos.Response;
using Refit;

namespace BlazorAutoCotacao.Services.Interfaces;

public interface ISuppliersApi
{
    [Post("/api/suppliers")]
    Task<CreateSupplierResponse> CreateSupplierAsync([Body] CreateSupplierDto request);

    [Get("/api/suppliers")]
    Task<GetAllSuppliersItemsResponse> GetAllSuppliersAsync(
        [Query] string? search = null,
        [Query] string? legalName = null,
        [Query] string? fantasyName = null,
        [Query] string? cnpj = null,
        [Query] string orderBy = "createdAt",
        [Query] int page = 1,
        [Query] int pageSize = 25);

    [Get("/api/suppliers/{id}")]
    Task<GetSupplierByIdResponse> GetSupplierByIdAsync(Guid id);

    [Put("/api/suppliers/{id}")]
    Task<UpdateSupplierResponse> UpdateSupplierAsync(Guid id, [Body] UpdateSupplierDto request);
}
