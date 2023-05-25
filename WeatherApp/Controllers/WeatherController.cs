using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;
using WeatherApp.Models;
using WeatherService.Interfaces;

namespace WeatherApp.Controllers
{
    
    public class WeatherController : Controller
    {
        private readonly IWeatherService _weatherService;

        public WeatherController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [Route ("/")]
        public IActionResult WeatherDisplayAll() 
        {
            if (Request.Method != "GET") { return BadRequest("App only processs GET requests"); }
            return View("WeatherDisplay",_weatherService.GetWeatherDetails());
        }



        [Route("/Weather/{CityCode}")]
        public IActionResult WeatherDisplay(string CityCode)
        {
            CityWeather? CityWeatherViaCityCode = _weatherService.GetWeatherByCityCode(CityCode);
            if (Request.Method != "GET") { return BadRequest("App only processs GET requests"); }
            if (CityWeatherViaCityCode != null)
            {
                return View("WeatherDisplay", new List<CityWeather>(){ CityWeatherViaCityCode });
            }
            return BadRequest("Invalid City Code");
            
        }
    }
}
