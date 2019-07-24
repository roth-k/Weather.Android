using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Weather.DataLayer.Current;
using Weather.Repository;

namespace Weather.Services.Implementations
{
    public class GetCurrentWeatherService : IGetCurrentWeatherService
    {
        CurrentWeather IGetCurrentWeatherService.Convert(string data) =>
            new JsonToObjectConverter().Convert<CurrentWeather>(data);

        public async Task<CurrentWeather> GetCurrentWeatherDefaultAsync(string location)
        {
            if (string.IsNullOrEmpty(location))
                return null;

            try
            {
                var json = await new DataLoader(location).GetCurrentWeatherJsonForCelsiusAsync();
                return await Task.Run(()=> (this as IGetCurrentWeatherService).Convert(json));
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<CurrentWeather> GetCurrentWeatherFarinheitAsync(string location)
        {
            if (string.IsNullOrEmpty(location))
                return null;

            try
            {
                var data = await new DataLoader(location).GetCurrentWeatherJsonForFarinheitAsync();
                return await Task.Run(() => (this as IGetCurrentWeatherService).Convert(data));
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        
        

       
    }
}
