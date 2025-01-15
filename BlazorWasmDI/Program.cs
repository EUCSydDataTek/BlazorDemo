using BlazorWasmDI;
using DISharedServices;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Singleton
builder.Services.AddSingleton<ITodoService, TodoService>();

// Scoped
//builder.Services.AddScoped<ITodoService, TodoService>();

// Trancient
//builder.Services.AddTransient<ITodoService, TodoService>();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
