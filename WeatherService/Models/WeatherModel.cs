using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace WeatherService.Models {
    [DataContract]
    public class WeatherModel {
        [DataMember]
        public string ID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string URL { get; set; }
        [DataMember]
        public DateTime Date { get; set; }
        [DataMember]
        public string Temperature { get; set; }

        public WeatherModel() { }
        public WeatherModel(string id, string date, string name) {
            ID = id;
            DateTime tempDate = DateTime.Now;
            Date = DateTime.TryParse(date, out tempDate) ? tempDate : tempDate;
            Name = name;
        }
    }
}
