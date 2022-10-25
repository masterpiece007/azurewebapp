using Microsoft.EntityFrameworkCore;

namespace CashEX.API
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<WeatherForecast> WeatherForecasts { get; set; }

    }
}

