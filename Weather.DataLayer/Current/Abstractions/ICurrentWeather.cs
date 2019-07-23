using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Weather.DataLayer.Current
{
    public interface ICurrentWeather
    {
        [JsonProperty("coord")]
        Coord Coord { get; set; }

        [JsonProperty("weather")]
        List<Weather> Weather { get; set; }

        [JsonProperty("base")]
        string Base { get; set; }

        [JsonProperty("main")]
        Main Main { get; set; }

        [JsonProperty("visibility")]
        int Visibility { get; set; }

        [JsonProperty("wind")]
        Wind Wind { get; set; }

        [JsonProperty("clouds")]
        Clouds Clouds { get; set; }

        [JsonProperty("dt")]
        int dt { get; set; }

        [JsonProperty("sys")]
        Sys sys { get; set; }

        [JsonProperty("timezone")]
        int timezone { get; set; }

        [JsonProperty("id")]
        int id { get; set; }

        [JsonProperty("name")]
        string name { get; set; }

        [JsonProperty("cod")]
        int cod { get; set; }
    }
}
