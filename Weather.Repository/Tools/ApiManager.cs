using System;
using System.Collections.Generic;
using System.Text;

namespace Weather.Repository
{
    public class ApiManager
    {
        private static ApiManager _instance;
        private static readonly object _lock = new object();
        private ApiManager() { }
        public static ApiManager Instance
        {
            get
            {

                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                            _instance = new ApiManager();

                    }
                }
                return _instance;
            }
        }

        private readonly string _accountID = @"&APPID=3e8964797115b07167aafce88ff63b2a";
        private readonly string _baseUrl = @"http://api.openweathermap.org/data/2.5/";
        private readonly string _current = "weather?q=";
        private readonly string _forecast = "forecast?q=";
        private readonly string _farinheit = "&units=imperial";
        private readonly string _celsius = "&units=metric";

       public string GetForecastUrlForCelsius(string location)=> 
            _baseUrl + _forecast + location + _celsius + _accountID;
       public string GetForecastUrlForFarinheit(string location)=>
             _baseUrl + _forecast + location + _farinheit + _accountID;
        public string GetCurrentWeatherUrlForCelsius(string location)=>
             _baseUrl + _current + location + _farinheit + _accountID;


    }
}
