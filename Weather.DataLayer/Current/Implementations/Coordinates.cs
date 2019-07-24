using System;
using System.Collections.Generic;
using System.Text;
using Weather.DataLayer.Current.Abstractions;

namespace Weather.DataLayer.Current.Implementations
{
    public class Coordinates : ICoordinates
    {
        public double Lon { get; set; }
        public double Lat { get; set; }
    }
}
