using BlazorAutoCotacao.Dtos.Request;
using BlazorAutoCotacao.Dtos.Response;
using BlazorAutoCotacao.Services.Interfaces;

namespace BlazorAutoCotacao.Services;

public class SuppliersService
{
    private readonly ISuppliersApi _suppliersApi;

    public SuppliersService(ISuppliersApi suppliersApi)
    {
        _suppliersApi = suppliersApi;
    }

    public async Task<CreateSupplierResponse> CreateSupplierAsync(CreateSupplierDto request)
    {
        return await _suppliersApi.CreateSupplierAsync(request);
    }

    public async Task<GetAllSuppliersItemsResponse> GetAllSuppliersAsync(
        string? search = null,
        string? legalName = null,
        string? fantasyName = null,
        string? cnpj = null,
        string orderBy = "createdAt",
        int page = 1,
        int pageSize = 25)
    {
        return await _suppliersApi.GetAllSuppliersAsync(search, legalName, fantasyName, cnpj, orderBy, page, pageSize);
    }

    public async Task<GetSupplierByIdResponse> GetSupplierByIdAsync(Guid supplierId)
    {
        return await _suppliersApi.GetSupplierByIdAsync(supplierId);
    }

    public async Task<UpdateSupplierResponse> UpdateSupplierAsync(UpdateSupplierDto request)
    {
        return await _suppliersApi.UpdateSupplierAsync(request);
    }
}
