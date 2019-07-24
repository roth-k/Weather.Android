using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Weather.DataLayer.Current.Implementations;

namespace Weather.DataLayer.Forecast.Abstractions
{
    public interface ICityGeographicalData
    {
        [JsonProperty("id")]
         int Id { get; set; }

        [JsonProperty("name")]
         string Name { get; set; }

        [JsonProperty("coord")]
         Coordinates Coord { get; set; }

        [JsonProperty("country")]
         string Country { get; set; }

        [JsonProperty("population")]
         int Population { get; set; }

        [JsonProperty("timezone")]
         int Timezone { get; set; }
    }
}
