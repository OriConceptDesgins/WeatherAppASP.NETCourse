using System.Collections.Generic;
using WeatherApp.Models;

namespace WeatherService.Interfaces
{
    public interface IWeatherService
    {
        CityWeather? GetWeatherByCityCode(string CityCode);

        List<CityWeather>  GetWeatherDetails();
    }
}
