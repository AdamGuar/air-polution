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
            DataProvider prov = new RestDataProvider();
            var list = Task.Run(() => prov.AllStations()).Result;

            var index = Task.Run(() => prov.StationAirQualityIndex(14)).Result;

            ViewBag.City = city;

            return View();
        }

    }
}