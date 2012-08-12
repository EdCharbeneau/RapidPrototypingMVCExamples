using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RapidPrototypingMVCExamples.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult ExampleOne()
        {
            return View();
        }

        public ActionResult ExampleTwo()
        {
            return View();
        }

        public ActionResult ExampleThree()
        {
            return View();
        }

        public ActionResult ExampleFour()
        {
            return View();
        }

        public ActionResult ExampleFive()
        {
            return View();
        }

        public ActionResult ExampleSix()
        {
            return View();
        }
    }
}
