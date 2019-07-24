using System;
using System.Collections.Generic;
using System.Text;
using Weather.DataLayer.Forecast.Abstractions;

namespace Weather.DataLayer.Forecast.Implementations
{
    public class Sys : ISys
    {
        public string Pod { get; set; }
    }
}
