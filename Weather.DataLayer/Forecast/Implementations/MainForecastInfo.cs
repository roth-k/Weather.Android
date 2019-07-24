using System;
using System.Collections.Generic;
using System.Text;
using Weather.DataLayer.Forecast.Abstractions;

namespace Weather.DataLayer.Forecast.Implementations
{
    public class MainForecastInfo : IMainForecastInfo
    {
        public double Temp { get; set; }
        public double TempMin { get; set; }
        public double TempMax { get; set; }
        public double Pressure { get; set; }
        public double SeaLevel { get; set; }
        public double GrndLevel { get; set; }
        public int Humidity { get; set; }
        public double TempKf { get; set; }
    }
}
