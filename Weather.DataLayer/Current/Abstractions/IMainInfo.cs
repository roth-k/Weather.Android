using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Weather.DataLayer.Current.Abstractions
{
    public interface IMainInfo
    {
        [JsonProperty("temp")]
         int Temp { get; set; }

        [JsonProperty("pressure")]
         int Pressure { get; set; }

        [JsonProperty("humidity")]
         int Humidity { get; set; }

        [JsonProperty("temp_min")]
         int Temp_min { get; set; }

        [JsonProperty("temp_max")]
         int Temp_max { get; set; }
    }
}
