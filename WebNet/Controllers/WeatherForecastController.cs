using Microsoft.AspNetCore.Mvc;
using WebNet.Services;

namespace WebNet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private IWeatherForecastService _weatherForecastService;

        public WeatherForecastController(IWeatherForecastService weather)
        {
            _weatherForecastService = weather;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return _weatherForecastService.GenerateWeatherForecast();
        }
    }
}
