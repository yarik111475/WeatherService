using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

using WeatherService.Models;

namespace WeatherService.Services {
    [ServiceContract]
    public interface IWeatherService {
        [OperationContract]
        void UploadData();
        [OperationContract]
        CityModel[] GetCities();
        [OperationContract]
        WeatherModel GetWeatherById(int id);
    }
}
