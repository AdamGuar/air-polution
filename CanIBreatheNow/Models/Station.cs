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
        int Id { get; set; }

        [JsonProperty("stationName")]
        String StationName { get; set; }

        [JsonProperty("gegrLat")]
        double GegrLat { get; set; }

        [JsonProperty("GegrLon")]
        double GegrLon { get; set; }

        [JsonProperty("city")]
        City City { get; set; }

        [JsonProperty("addressStreet")]
        String AddressStreet { get; set; }
    }


    public class City
    {
        [JsonProperty("id")]
        int Id { get; set; }

        [JsonProperty("name")]
        String Name { get; set; }

        [JsonProperty("commune")]
        Commune Commune { get; set; }
    }

    public class Commune
    {
        [JsonProperty("communeName")]
        String CommuneName { get; set; }

        [JsonProperty("districtName")]
        String DistrictName { get; set; }

        [JsonProperty("provinceName")]
        String ProvinceName { get; set; }
    }

}