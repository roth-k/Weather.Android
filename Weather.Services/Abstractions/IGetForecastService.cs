using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Weather.DataLayer.Forecast.Implementations;

namespace Weather.Services.Abstractions
{
    public interface IGetForecastService
    {
        Task<ForecastWeather> GetForecatsDefault(string location);
        Task<ForecastWeather> GetForecastFarinheit(string location);
        ForecastWeather ConvertJson(string data);
    }
}
