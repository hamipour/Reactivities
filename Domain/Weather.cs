using System;

namespace Domain
{
    public class Weather
    {
        public int Id { get; set; }
        public DateTime WeatherDate { get; set; }
        public int TemperetureC { get; set; }
        public int TemperetureF { get; set; }
        public string Summary { get; set; }
    }
}
