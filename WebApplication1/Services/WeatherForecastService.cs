using ClassLibrary1.Data;
using Newtonsoft.Json;
using System.Text;

namespace WebApplication1.Services;

public interface IWeatherForecastService
{
	Task<WeatherForecast[]> GetForecastAsync(DateTime startDate);
}

public class WeatherForecastService : IWeatherForecastService
{
	private static readonly string[] Summaries = new[]
	{
		"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
	};

	public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
	{
        return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = startDate.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        }).ToArray());
        

    }
}

