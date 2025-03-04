
namespace TypedClientDemo.Services
{
    public interface ILocalWeatherService
    {
        Task<WeatherForecast[]?> GetLocalWeatherAsync();
    }
}