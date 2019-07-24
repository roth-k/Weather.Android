using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Weather.DataLayer.Forecast.Abstractions
{
    public interface ISys
    {
        [JsonProperty("pod")]
         string Pod { get; set; }
    }
}
