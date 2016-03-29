using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var xy = "Exigo";
            var yx = "ExigoOV";
            var xyy = "ExigoReplicatedSite";
            var xxy = "EXIGOovrp";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Mi aplicacion con modificaciones subidas al GITHUB";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
