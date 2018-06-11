using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using WeatherService.Models;

namespace WeatherService.Repositories {
    public interface ICityRepository {
        CityModel[] GetCities();
        CityModel GetCityById(int id);
        void AddCity(CityModel city);
        void DeleteCity(int id);
    }
}
