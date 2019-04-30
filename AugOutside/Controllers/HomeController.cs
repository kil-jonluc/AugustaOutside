using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AugOutside.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Biking()
        {
            ViewBag.Message = "What is your favorite biking trail?";

            return View();
        }

     
        public ActionResult DiscGolf()
        {
            ViewBag.Message = "Disc Golf page.";

            return View();
        }
        public ActionResult Hiking()
        {
            ViewBag.Message = "Hiking page.";

            return View();
        }
        public ActionResult Paddling()
        {
            ViewBag.Message = "Paddling page.";

            return View();
        }
        public ActionResult Walking()
        {
            ViewBag.Message = "Walking page.";

            return View();
        }
    }
}