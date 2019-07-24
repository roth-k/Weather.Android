using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Weather.DataLayer.Current.Abstractions
{
    public interface ICoordinates
    {
        [JsonProperty("lon")]
         double Lon { get; set; }

        [JsonProperty("lat")]
         double Lat { get; set; }
    }
}
