using CanIBreatheNow.Models;
using CanIBreatheNow.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace CanIBreatheNow.Logic
{
    public class DataProcessor
    {
        DataProvider prov = new RestDataProvider();

        public List<StationIndexModel> GetStationIndexesByCity(String city) {
            List<StationIndexModel> result = new List<StationIndexModel>();
            List<Station> list = Task.Run(() => prov.AllStations()).Result;
            List<Station> filteredList = list.Where(station => station.City.Name.Equals(city)).ToList();
            if (filteredList.Any()) { 
                filteredList.ForEach(station =>
                {
                    AirQualityIndex index = Task.Run(() => prov.StationAirQualityIndex(station.Id)).Result;
                    StationIndexModel stationIndex = new StationIndexModel(station.StationName,station.AddressStreet,index);
                    result.Add(stationIndex);
                });
            }
            else
            {
                throw new NoDataFoundException($"No data found for city: {city}");
            }

            return result;
        }


        public WeatherData GetCityWeather(String city)
        {
            return Task.Run(() => prov.WeatherDataByCity(city)).Result;
        }


        public String GetMostFrequentIndex(List<StationIndexModel> list)
        {

            List<String> allGeneralIndexes = new List<String>();
            list.ForEach(el =>
            {
                allGeneralIndexes.Add(el.StationIndex.StIndexLvl.IndexLvlName);
            });

            return allGeneralIndexes.GroupBy(i => i).OrderByDescending(grp => grp.Count()).Select(grp => grp.Key).First();
        }


    }
}