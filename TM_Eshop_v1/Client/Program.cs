global using TM_Eshop_v1.Shared;
global using TM_Eshop_v1.Client.Services.ProductService;
global using TM_Eshop_v1.Client.Services.CategoryService;
global using System.Net.Http.Json;
global using Blazored.LocalStorage;
global using TM_Eshop_v1.Client.Services.CartService;
global using TM_Eshop_v1.Client.Services.OrderService;

using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using TM_Eshop_v1.Client;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddBlazoredLocalStorage();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<IProductServiceInterface, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ICartService, CartService>();
builder.Services.AddScoped<IOrderService, OrderService>();

await builder.Build().RunAsync();
