using System;
using System.Collections.Generic;
using System.Text;
using Weather.DataLayer.Current.Implementations;
using Weather.DataLayer.Forecast.Abstractions;

namespace Weather.DataLayer.Forecast.Implementations
{
    public class CityGeographicalData : ICityGeographicalData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Coordinates Coord { get; set; }
        public string Country { get; set; }
        public int Population { get; set; }
        public int Timezone { get; set; }
    }
}
