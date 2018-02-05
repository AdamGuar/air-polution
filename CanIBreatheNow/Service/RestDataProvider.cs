using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CanIBreatheNow.Models;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace CanIBreatheNow.Service
{
    public class RestDataProvider : DataProvider
    {
        private const String RestServiceAddr = "http://api.gios.gov.pl/pjp-api/rest/";
        private const String WeatherServiceAddr = "http://api.openweathermap.org/data/2.5/weather?appid=8e4e048d2c720e871b6ee90268a40dae&units=metric&q=";
        HttpClient client = new HttpClient();

 

        public async Task<List<Station>> AllStations()
        {
            List<Station> result = null;
            HttpResponseMessage response = await client.GetAsync(RestServiceAddr + "station/findAll");
            if (response.IsSuccessStatusCode)
            {
                result = await response.Content.ReadAsAsync<List<Station>>();
            }
            return result;
        }

        public async Task<AirQualityIndex> StationAirQualityIndex(int stationID)
        {
            AirQualityIndex result = null;
            HttpResponseMessage response = await client.GetAsync(RestServiceAddr + "aqindex/getIndex/"+stationID);
            if (response.IsSuccessStatusCode)
            {
                result = await response.Content.ReadAsAsync<AirQualityIndex>();
            }
            return result;
        }

        public async Task<WeatherData> WeatherDataByCity(string city)
        {
            WeatherData result = null;
            HttpResponseMessage response = await client.GetAsync(WeatherServiceAddr + city);
            if (response.IsSuccessStatusCode)
            {
                result = await response.Content.ReadAsAsync<WeatherData>();
            }
            return result;
        }
    }
}