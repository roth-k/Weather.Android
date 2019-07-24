using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Weather.DataLayer.Current;

namespace Weather.Services
{
    public interface IGetCurrentWeatherService
    {
        Task<CurrentWeather>GetCurrentWeatherDefaultAsync(string location);
        Task<CurrentWeather> GetCurrentWeatherFarinheitAsync(string location);
        CurrentWeather Convert(string data);
    }
}
