using Dumpify;
using HttpClientApp;
using System.Net.Http.Json;

using HttpClient client = new();
client.BaseAddress = new Uri("http://localhost:5234");

var result = await client.GetAsync("WeatherForecast");

if (result.IsSuccessStatusCode)
{
    var weatherforecast = await result.Content.ReadFromJsonAsync<WeatherForecast[]>();
    weatherforecast.Dump();
}

client.Dispose();

Console.ReadLine();