using FlyingDonkey_TodoApp.Application.WeatherForecasts.Queries.GetWeatherForecasts;
using Microsoft.AspNetCore.Mvc;

namespace FlyingDonkey_TodoApp.WebUI.Controllers;

public class WeatherForecastController : ApiControllerBase
{
    [HttpGet]
    public async Task<IEnumerable<WeatherForecast>> Get()
    {
        return await Mediator.Send(new GetWeatherForecastsQuery());
    }
}
