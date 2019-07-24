using System;
using System.Collections.Generic;
using System.Text;
using Weather.DataLayer.Current.Abstractions;

namespace Weather.DataLayer.Current.Implementations
{
    public class Cloud : ICloud
    {
        public int All { get; set; }
    }
}
