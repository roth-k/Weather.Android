using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Weather.Repository
{
    public class StringToJsonConverter
    {
        public T Convert<T>(string data) =>
            JsonConvert.DeserializeObject<T>(data);
    }
}
