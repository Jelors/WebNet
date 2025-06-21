using WebNet.Services;
using WebNet.Models;
using Microsoft.EntityFrameworkCore;

namespace WebNet
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<IWeatherForecastService, WeatherForecastService>();

            builder.Services.AddHttpClient<PostService>();


            var app = builder.Build();

            //Database
           // var connection = builder.Configuration.GetConnectionString("DefaultConnection");
           // builder.Services.AddDbContext<TestContext>(options => options.UseSqlServer(connection));

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.MapGet("/", () => "Hello from root!");

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
