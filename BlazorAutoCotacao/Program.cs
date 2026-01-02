using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorAutoCotacao;
using BlazorAutoCotacao.Services;
using BlazorAutoCotacao.Services.Interfaces;
using MudBlazor.Services;
using Refit;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddMudServices();
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Configuração da URL base da API
var apiBaseUrl = "http://localhost:5154";

// Registro dos clientes Refit
builder.Services.AddRefitClient<IQuotesApi>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri(apiBaseUrl));

builder.Services.AddRefitClient<ISuppliersApi>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri(apiBaseUrl));

// Registro dos Services
builder.Services.AddScoped<QuotesService>();
builder.Services.AddScoped<SuppliersService>();

await builder.Build().RunAsync();