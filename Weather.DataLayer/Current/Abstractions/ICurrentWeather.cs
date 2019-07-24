using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Weather.DataLayer.Current.Implementations;

namespace Weather.DataLayer.Current
{
    public interface ICurrentWeather
    {
        [JsonProperty("coord")]
        Coordinates Coord { get; set; }

        [JsonProperty("weather")]
        List<WeatherDescribtion> Weather { get; set; }

        [JsonProperty("base")]
        string Base { get; set; }

        [JsonProperty("main")]
        MainInfo Main { get; set; }

        [JsonProperty("visibility")]
        int Visibility { get; set; }

        [JsonProperty("wind")]
        Wind Wind { get; set; }

        [JsonProperty("clouds")]
        Cloud Clouds { get; set; }

        [JsonProperty("dt")]
        int Dt { get; set; }

        [JsonProperty("sys")]
        GeographicalData GeoData { get; set; }

        [JsonProperty("timezone")]
        int Timezone { get; set; }

        [JsonProperty("id")]
        int ID { get; set; }

        [JsonProperty("name")]
        string Name { get; set; }

        [JsonProperty("cod")]
        int Cod { get; set; }
    }
}
