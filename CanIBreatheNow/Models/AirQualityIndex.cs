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
        public String IndexDate { get; set; }


        [JsonProperty ("stIndexLevel")]
        public IndexLvl StIndexLvl { get; set; }

        [JsonProperty("so2IndexLevel")]
        public IndexLvl SO2Index { get; set; }

        [JsonProperty("no2IndexLevel")]
        public IndexLvl NO2Index { get; set; }

        [JsonProperty("pm10IndexLevel")]
        public IndexLvl PM10Index { get; set; }

        [JsonProperty("pm25IndexLevel")]
        public IndexLvl PM25Index { get; set; }
        

    }


    public class IndexLvl {
        [JsonProperty("indexLevelName")]
    public String IndexLvlName { get; set; }
    }

}