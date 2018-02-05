using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CanIBreatheNow.Models
{
    public class WeatherData
    {
        [JsonProperty("main")]
        public Main _Main { get; set; }

        [JsonProperty("wind")]
        public Wind _Wind { get; set; }



        public class Main {
            [JsonProperty("temp")]
            public double temp { get; set; }
        }

        public class Wind {
            [JsonProperty("speed")]
            public double wind { get; set; }

        }


    }
}