﻿using CanIBreatheNow.Logic;
using CanIBreatheNow.Models;
using CanIBreatheNow.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace CanIBreatheNow.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Conditions(String city)
        {
            AirQualityIndexTranslator translator = new AirQualityIndexTranslator();
            DataProcessor procesor = new DataProcessor();
            List<StationIndexModel> stationsIndexes = new List<StationIndexModel>();

            try {
                stationsIndexes = procesor.GetStationIndexesByCity(city);
            }catch(NoDataFoundException e)
            {
                StationIndexModel model = new StationIndexModel("No sensor provided for given city","N/A",new AirQualityIndex() { StIndexLvl = new IndexLvl() { IndexLvlName = "No sensor provided for given city" } });
                stationsIndexes.Add(model);
            }

            stationsIndexes = translator.TranslateIndexes(stationsIndexes);

            var conditions = procesor.GetCityWeather(city);
            var mostFrequentIndex = procesor.GetMostFrequentIndex(stationsIndexes);

            ViewBag.City = city;
            ViewBag.Temperature = conditions._Main.temp;
            ViewBag.Wind = conditions._Wind.wind;
            ViewBag.AirIndex = mostFrequentIndex;
            ViewBag.Stations = stationsIndexes;

            return View();
        }

    }
}