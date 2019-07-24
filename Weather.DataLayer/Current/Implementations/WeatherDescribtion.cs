using System;
using System.Collections.Generic;
using System.Text;
using Weather.DataLayer.Current.Abstractions;

namespace Weather.DataLayer.Current.Implementations
{
    public class WeatherDescribtion : IWeatherDetails
    {
        public int Id { get; set; }
        public string Main { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
    }
}
