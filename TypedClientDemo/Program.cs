using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using TypedClientDemo;
using TypedClientDemo.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped<ILocalWeatherService,LocalWeatherService>();
builder.Services.AddScoped<IWeatherApiService,WeatherApiService>();

builder.Services.AddHttpClient<ILocalWeatherService,LocalWeatherService>(c => c.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));
builder.Services.AddHttpClient<IWeatherApiService,WeatherApiService>(c => c.BaseAddress = new Uri("http://localhost:5234"));

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
