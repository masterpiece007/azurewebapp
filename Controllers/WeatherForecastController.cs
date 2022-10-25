using Microsoft.AspNetCore.Mvc;

namespace CashEX.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly AppDbContext context;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,AppDbContext context)
        {
            _logger = logger;
            this.context = context;
        }

        [HttpGet(Name = "GetWeatherForecast_")]
        public IEnumerable<WeatherForecast> Get()
        {
            return context.WeatherForecasts.ToList();
            //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = DateTime.Now.AddDays(index),
            //    TemperatureC = Random.Shared.Next(-20, 55),
            //    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            //})
            //.ToArray();
        }
    }
}