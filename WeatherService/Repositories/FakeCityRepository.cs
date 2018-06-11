using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using WeatherService.Models;

namespace WeatherService.Repositories {
    public class FakeCityRepository : ICityRepository {
        static List<CityModel> cities = null;
        static FakeCityRepository() {
            cities = new List<CityModel> {
                new CityModel{ID="0",Name="city000", URL="url000" },
                new CityModel{ID="1",Name="city001", URL="url001" },
                new CityModel{ID="2",Name="city002", URL="url002" }
            };
        }

        public void AddCity(CityModel city) {
            cities.Add(city);
        }

        public void DeleteCity(int id) {
            CityModel city = cities.Where(c => c.ID == id.ToString()).FirstOrDefault();
            if (city != null) {
                cities.Remove(city);
            }
        }

        public CityModel[] GetCities() {
            return cities.ToArray();
        }

        public CityModel GetCityById(int id) {
            CityModel city = cities.Where(c => c.ID == id.ToString()).FirstOrDefault();
            if (city != null) {
                return city;
            }
            return null;
        }
    }
}
