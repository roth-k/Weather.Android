using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Weather.DataLayer.Current.Abstractions
{
    public interface ICloud
    {
        [JsonProperty("all")]
         int All { get; set; }
    }
}
