using System;
using System.Collections.Generic;
using System.Text;
using Weather.DataLayer.Forecast.Abstractions;

namespace Weather.DataLayer.Forecast.Implementations
{
    public class Rain : IRain
    {
        public double Hourly { get; set; }
    }
}
