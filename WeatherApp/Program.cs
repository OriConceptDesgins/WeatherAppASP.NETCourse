using WeatherService.Interfaces;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IWeatherService, WeatherService.WeatherService>(); //Because the class is the same name as the namespace.
var app = builder.Build();
app.UseStaticFiles();
app.MapControllers();
app.Run();
