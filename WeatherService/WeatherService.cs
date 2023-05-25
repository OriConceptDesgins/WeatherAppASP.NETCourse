using WeatherApp.Models;
using WeatherService.Interfaces;

namespace WeatherService
{
    public class WeatherService :IWeatherService
    {
        private List<CityWeather> _cityWeatherList = new List<CityWeather>
        {

            new CityWeather
            {
                CityCode = "1",
                CityName = "New York City",
                DateAndTime = DateTime.Now,
                TemperatureF = 48
            },

            new CityWeather
            {
                CityCode = "666",
                CityName = "Lux City",
                DateAndTime = DateTime.Now,
                TemperatureF = 32
            },

            new CityWeather
            {
                CityCode = "38044",
                CityName = "Kyiv",
                DateAndTime = DateTime.Now,
                TemperatureF = 56
            },

        };

        public CityWeather? GetWeatherByCityCode(string CityCode) 
        { 
            foreach( CityWeather city in _cityWeatherList) 
            {
                if ( city.CityCode == CityCode) return city;
            }  
            return null;
        }



        public List<CityWeather> GetWeatherDetails()
        {
            return _cityWeatherList;
        }

    }
}