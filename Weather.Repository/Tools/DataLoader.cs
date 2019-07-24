using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;
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

        public async Task<string> GetCurrentWeatherJsonForCelsiusAsync() =>
            await DowloadAcync(ApiManager.Instance.GetCurrentWeatherUrlForCelsius(_location));
        public async Task<string> GetCurrentWeatherJsonForFarinheitAsync() =>
           await DowloadAcync(ApiManager.Instance.GetCurrentWeatherUrlForFarinheit(_location));
        public async Task<string> GetForecastJsonForFarinheitAsync() =>
           await DowloadAcync(ApiManager.Instance.GetForecastUrlForFarinheit(_location));
        public async Task<string> GetForecastJsonForCelsiusAsync() =>
          await DowloadAcync(ApiManager.Instance.GetForecastUrlForCelsius(_location));

        private async Task<string> DowloadAcync(string url)
        {
            using (var wc = new WebClient())
            {
                return await wc.DownloadStringTaskAsync(url);
            }
        }
    }
}
