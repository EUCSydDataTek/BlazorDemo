
namespace TypedClientDemo.Services
{
    public interface IWeatherApiService
    {
        Task<WeatherForecast[]?> GetWeatherForecasts();
    }
}