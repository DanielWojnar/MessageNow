using Blazored.LocalStorage;
using Blazored.Modal;
using Blazored.Toast;
using MessageNow;
using MessageNow.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddBlazoredLocalStorage();
builder.Services.AddBlazoredModal();
builder.Services.AddBlazoredToast();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSingleton<IHttpClientService, HttpClientService>();

await builder.Build().RunAsync();
