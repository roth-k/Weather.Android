using System;
using System.Collections.Generic;
using System.Text;
using Weather.DataLayer.Current;

namespace Weather.Repository
{
    public class DataLoader
    {
        private string _location { get; set; }
        public DataLoader(string location)
        {
            this._location = location;
        }
        public async Task<CurrentWeather>
    }
}
