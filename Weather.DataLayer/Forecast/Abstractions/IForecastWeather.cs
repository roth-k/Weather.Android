using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Weather.DataLayer.Forecast.Implementations;

namespace Weather.DataLayer.Forecast.Abstractions
{
    public interface IForecastWeather
    {
        [JsonProperty("cod")]
         string Cod { get; set; }

        [JsonProperty("message")]
         double Message { get; set; }

        [JsonProperty("cnt")]
         int Cnt { get; set; }

        [JsonProperty("list")]
         List<BaseInfo> Info { get; set; }

        [JsonProperty("city")]
        CityGeographicalData City { get; set; }
    }
}
