using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Weather.DataLayer.Forecast.Implementations;
using Weather.Repository;
using Weather.Services.Abstractions;

namespace Weather.Services.Implementations
{
    public class GetForecastService : IGetForecastService
    {
        ForecastWeather IGetForecastService.ConvertJson(string data) =>
            new JsonToObjectConverter().Convert<ForecastWeather>(data);

        public async Task<ForecastWeather> GetForecatsDefault(string location)
        {
            if (string.IsNullOrEmpty(location))
                return null;
            try
            {
                var data = await new DataLoader(location).GetForecastJsonForCelsiusAsync();
                return await Task.Run(() => (this as IGetForecastService).ConvertJson(data));
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<ForecastWeather> GetForecastFarinheit(string location)
        {
            if (string.IsNullOrEmpty(location))
                return null;
            try
            {
                var data = await new DataLoader(location).GetForecastJsonForFarinheitAsync();
                return await Task.Run(() => (this as IGetForecastService).ConvertJson(data));
            }
            catch (Exception ex)
            {
                return null;
            }
        }

       
    }
}
