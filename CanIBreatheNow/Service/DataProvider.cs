using CanIBreatheNow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanIBreatheNow.Service
{
    interface DataProvider
    {
        Task<List<Station>> AllStations();

        Task<AirQualityIndex> StationAirQualityIndex(int stationID);
    }
}
