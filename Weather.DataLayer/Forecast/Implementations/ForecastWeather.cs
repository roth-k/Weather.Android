using System;
using System.Collections.Generic;
using System.Text;
using Weather.DataLayer.Forecast.Abstractions;

namespace Weather.DataLayer.Forecast.Implementations
{
    public class ForecastWeather : IForecastWeather
    {
        public string Cod { get; set; }
        public double Message { get; set; }
        public int Cnt { get; set; }
        public List<BaseInfo> Info { get; set; }
        public CityGeographicalData City { get; set; }
    }
}
