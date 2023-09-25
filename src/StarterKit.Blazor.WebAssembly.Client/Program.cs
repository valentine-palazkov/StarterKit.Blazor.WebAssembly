using Blazored.LocalStorage;
using Fluxor;
using Fluxor.Persist.Middleware;
using Fluxor.Persist.Storage;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using StarterKit.Blazor.WebAssembly.Client;
using StarterKit.Blazor.WebAssembly.Client.Services.Contracts;
using StarterKit.Blazor.WebAssembly.Client.Services.Implementations;
using StarterKit.Blazor.WebAssembly.Client.State;
using StarterKit.Blazor.WebAssembly.Client.States;
using Toolbelt.Blazor.Extensions.DependencyInjection;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddFluxor(configure =>
{
    configure.ScanAssemblies(typeof(Program).Assembly);
    configure.UsePersist(options => options.UseInclusionApproach());
#if DEBUG
    configure.UseReduxDevTools();
#endif
});

builder.Services.AddBlazoredLocalStorage();

builder.Services.AddScoped<IStringStateStorage, LocalStateStorage>();
builder.Services.AddScoped<IStoreHandler, JsonStoreHandler>();

builder.Services.AddOptions();
builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<IdentityAuthenticationStateProvider>();

builder.Services.AddScoped<AuthenticationStateProvider>(s => s.GetRequiredService<IdentityAuthenticationStateProvider>());
builder.Services.AddScoped<IAuthorizeApi, AuthorizeApi>();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddPWAUpdater();

await builder.Build().RunAsync();