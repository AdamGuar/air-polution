using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CanIBreatheNow.Models
{
    public class StationIndexModel
    {

        public String StationName { get; set; }
        public String StationAdress { get; set; }

        public AirQualityIndex StationIndex { get; set; }


        public StationIndexModel(String stationName, String stationAdress, AirQualityIndex stationIndex) {
            StationName = stationName;
            StationAdress = stationAdress;
            StationIndex = stationIndex;
        }

    }
}