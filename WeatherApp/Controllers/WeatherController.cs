using Microsoft.AspNetCore.Mvc;
using WeatherApp.Models;

namespace WeatherApp.Controllers
{
    
    public class WeatherController : Controller
    {
        List<CityWeather> cityWeatherList = new List<CityWeather>
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

        List<CityWeather> cityWeatherSelection= new List<CityWeather>{};
        
        [Route ("/")]
        public IActionResult WeatherDisplayAll() 
        {
            if (Request.Method != "GET") { return BadRequest("App only processs GET requests"); }
            if (HttpContext.GetRouteValue("City") == null)
            {
                return View("WeatherDisplay", cityWeatherList);
            }
            return BadRequest();
        }



        [Route("/Weather/{CityCode}")]
        public IActionResult WeatherDisplay()
        {
            if (Request.Method != "GET") { return BadRequest("App only processs GET requests"); }
            cityWeatherSelection.Clear();

            foreach (CityWeather cityWeather in cityWeatherList) 
            {
                string? cityCode = Convert.ToString(HttpContext.GetRouteValue("CityCode"));
                if (cityWeather.CityCode == cityCode) 
                {
                    cityWeatherSelection.Add(cityWeather);
                    return View("WeatherDisplay", cityWeatherSelection);
                }
            }
            return BadRequest("Bad Request, Wrong City code");
        }
    }
}
