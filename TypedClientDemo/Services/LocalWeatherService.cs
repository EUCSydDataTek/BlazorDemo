using System.Net.Http.Json;

namespace TypedClientDemo.Services
{
    public class LocalWeatherService : ILocalWeatherService
    {

        private HttpClient _httpClient;

        public LocalWeatherService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<WeatherForecast[]?> GetLocalWeatherAsync()
        {
            var result = await _httpClient.GetAsync("sample-data/weather.json");

            if (result.IsSuccessStatusCode)
            {
                return await result.Content.ReadFromJsonAsync<WeatherForecast[]>();
            }
            else
            {
                return Array.Empty<WeatherForecast>();
            }
        }

    }
}
