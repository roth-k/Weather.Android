using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Weather.DataLayer.Current.Abstractions
{
    public interface IWeatherDetails
    {
        [JsonProperty("id")]
         int Id { get; set; }

        [JsonProperty("main")]
         string Main { get; set; }

        [JsonProperty("description")]
         string Description { get; set; }

        [JsonProperty("icon")]
         string Icon { get; set; }
    }
}
