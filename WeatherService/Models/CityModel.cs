using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace WeatherService.Models {
    [DataContract]
    public class CityModel {
        [DataMember]
        public string ID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string URL { get; set; }

        public CityModel() { }
        public CityModel(string id, string name) {
            ID = id;
            Name = name;
        }
    }
}
