using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using WeatherService.Models;

namespace WeatherService.Repositories {
    public interface IWeatherRepository {
        WeatherModel[] GetWeathers();
        WeatherModel GetWeatherById(int id);
        void AddWeather(WeatherModel weather);
        void DeleteWeather(int id);
    }
}
