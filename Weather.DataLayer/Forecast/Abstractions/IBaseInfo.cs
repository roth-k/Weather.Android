using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Weather.DataLayer.Current.Implementations;
using Weather.DataLayer.Forecast.Implementations;

namespace Weather.DataLayer.Forecast.Abstractions
{
    public interface IBaseInfo
    {
        [JsonProperty("dt")]
         int Dt { get; set; }

        [JsonProperty("main")]
        MainForecastInfo Main { get; set; }

        [JsonProperty("weather")]
         List<WeatherDescribtion> Weather { get; set; }

        [JsonProperty("clouds")]
         Cloud Clouds { get; set; }

        [JsonProperty("wind")]
         Wind Wind { get; set; }

        [JsonProperty("rain")]
         Rain Rain { get; set; }

        [JsonProperty("sys")]
         Sys Sys { get; set; }

        [JsonProperty("dt_txt")]
         string DtTxt { get; set; }
    }
}
