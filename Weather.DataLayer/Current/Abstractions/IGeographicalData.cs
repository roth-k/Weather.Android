using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Weather.DataLayer.Current.Abstractions
{
    public interface IGeographicalData
    {
        [JsonProperty("type")]
         int Type { get; set; }

        [JsonProperty("id")]
         int Id { get; set; }

        [JsonProperty("message")]
         double Message { get; set; }

        [JsonProperty("country")]
         string Country { get; set; }

        [JsonProperty("sunrise")]
         int Sunrise { get; set; }

        [JsonProperty("sunset")]
         int Sunset { get; set; }
    }
}
