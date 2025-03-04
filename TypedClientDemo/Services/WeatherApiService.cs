using System.Net.Http.Json;

namespace TypedClientDemo.Services
{
    public class WeatherApiService : IWeatherApiService
    {

        private HttpClient _HttpClient;

        public WeatherApiService(HttpClient httpClient)
        {
            _HttpClient = httpClient;
        }

        public async Task<WeatherForecast[]?> GetWeatherForecasts()
        {
            var result = await _HttpClient.GetAsync("WeatherForecast");

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
