using System;
using System.Collections.Generic;
using System.Text;
using Weather.DataLayer.Current.Abstractions;

namespace Weather.DataLayer.Current.Implementations
{
    public class MainInfo : IMainInfo
    {
        public int Temp { get; set; }
        public int Pressure { get; set; }
        public int Humidity { get; set; }
        public int TempMin { get; set; }
        public int TempMax { get; set; }
    }
}
