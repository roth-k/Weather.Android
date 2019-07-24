using System;
using System.Collections.Generic;
using System.Text;
using Weather.DataLayer.Current.Abstractions;

namespace Weather.DataLayer.Current.Implementations
{
    public class Wind : IWind
    {
        public double Speed { get; set; }
        public double Deg { get; set; }
    }
}
