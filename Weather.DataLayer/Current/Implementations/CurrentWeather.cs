using System;
using System.Collections.Generic;
using System.Text;
using Weather.DataLayer.Current.Implementations;

namespace Weather.DataLayer.Current
{
    public class CurrentWeather : ICurrentWeather
    {
        public Coordinates Coord { get; set; }
        public List<WeatherDescribtion> Weather { get; set; }
        public string Base { get; set; }
        public MainInfo Main { get; set; }
        public int Visibility { get; set; }
        public Wind Wind { get; set; }
        public Cloud Clouds { get; set; }
        public int Dt { get; set; }
        public GeographicalData GeoData { get; set; }
        public int Timezone { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public int Cod { get; set; }
    }
}
