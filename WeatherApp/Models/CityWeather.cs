namespace WeatherApp.Models
{
    public class CityWeather
    {
        public string? CityCode { get; set; }
        public string? CityName { get; set; }
        public DateTime? DateAndTime { get; set; }
        public int? TemperatureF {get; set; }
    }
}
