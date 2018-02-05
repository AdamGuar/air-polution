using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CanIBreatheNow.Models
{
    public class Station
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("stationName")]
        public String StationName { get; set; }

        [JsonProperty("gegrLat")]
        public double GegrLat { get; set; }

        [JsonProperty("GegrLon")]
        public double GegrLon { get; set; }

        [JsonProperty("city")]
        public City City { get; set; }

        [JsonProperty("addressStreet")]
        public String AddressStreet { get; set; }
    }


    public class City
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public String Name { get; set; }

        [JsonProperty("commune")]
        public Commune Commune { get; set; }
    }

    public class Commune
    {
        [JsonProperty("communeName")]
        public String CommuneName { get; set; }

        [JsonProperty("districtName")]
        public String DistrictName { get; set; }

        [JsonProperty("provinceName")]
        public String ProvinceName { get; set; }
    }

}