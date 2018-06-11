using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

using WeatherService.Models;

namespace WeatherService.Services {
    public class WeatherService : IWeatherService {
        public CityModel[] GetCities() {
            throw new NotImplementedException();
        }

        public WeatherModel GetWeatherById(int id) {
            throw new NotImplementedException();
        }

        public void UploadData() {
            throw new NotImplementedException();
        }
    }
}
