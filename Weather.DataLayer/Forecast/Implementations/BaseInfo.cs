using System;
using System.Collections.Generic;
using System.Text;
using Weather.DataLayer.Current.Implementations;
using Weather.DataLayer.Forecast.Abstractions;

namespace Weather.DataLayer.Forecast.Implementations
{
    public class BaseInfo : IBaseInfo
    {
        public int Dt { get; set; }
        public MainForecastInfo Main { get; set; }
        public List<WeatherDescribtion> Weather { get; set; }
        public Cloud Clouds { get; set; }
        public Wind Wind { get; set; }
        public Rain Rain { get; set; }
        public Sys Sys { get; set; }
        public string DtTxt { get; set; }
    }
}
