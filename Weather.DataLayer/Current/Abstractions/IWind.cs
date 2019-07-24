using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Weather.DataLayer.Current.Abstractions
{
    public interface IWind
    {
        [JsonProperty("speed")]
         double Speed { get; set; }

        [JsonProperty("deg")]
         double Deg { get; set; }
    }
}
