using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using WeatherService.Models;

namespace WeatherService.Repositories {
    public class FakeWeatherRepository : IWeatherRepository {
        static List<WeatherModel> weathers = null;
        static FakeWeatherRepository() {
            weathers = new List<WeatherModel> {
                new WeatherModel{ID="0", Name="name000", URL="url000",Temperature="temp000" },
                new WeatherModel{ID="1", Name="name001", URL="url001",Temperature="temp001" },
                new WeatherModel{ID="2", Name="name002", URL="url002",Temperature="temp002" }
            };
        }

        public void AddWeather(WeatherModel weather) {
            weathers.Add(weather);
        }

        public void DeleteWeather(int id) {
            WeatherModel weather = weathers.Where(w => w.ID == id.ToString()).FirstOrDefault();
            if (weather != null) {
                weathers.Remove(weather);
            }
        }

        public WeatherModel GetWeatherById(int id) {
            WeatherModel weather = weathers.Where(w => w.ID == id.ToString()).FirstOrDefault();
            if (weather != null) {
                return weather;
            }
            return null;
        }

        public WeatherModel[] GetWeathers() {
            return weathers.ToArray();
        }
    }
}
