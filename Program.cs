global using Fluxor.Blazor.Web.Components;
global using Refit;
using DemoShop;
using DemoShop.DependencyInjection;
using DemoShop.HttpClients;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Radzen;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddRadzenComponents();
builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.ConfigureFluxor();
builder.Services.AddRefitClient<IFakeStoreApi>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri("https://fakestoreapi.com"));

await builder.Build().RunAsync();
