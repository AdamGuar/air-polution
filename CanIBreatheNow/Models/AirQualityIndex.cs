using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CanIBreatheNow.Models
{
    public class AirQualityIndex
    {
        [JsonProperty("stCalcDate")]
        String IndexDate { get; set; }

        [JsonProperty("so2IndexLevel")]
        IndexLvl SO2Index { get; set; }

        [JsonProperty("no2IndexLevel")]
        IndexLvl NO2Index { get; set; }

        [JsonProperty("pm10IndexLevel")]
        IndexLvl PM10Index { get; set; }

        [JsonProperty("pm25IndexLevel")]
        IndexLvl PM25Index { get; set; }
        

    }


    public class IndexLvl {
        [JsonProperty("indexLevelName")]
        String indexLvl { get; set; }
    }

}