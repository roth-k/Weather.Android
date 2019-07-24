using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Weather.DataLayer.Forecast.Abstractions
{
    public interface IRain
    {
        [JsonProperty("3h")]
         double Hourly { get; set; }
}
}
