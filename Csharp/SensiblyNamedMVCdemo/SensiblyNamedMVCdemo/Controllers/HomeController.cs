using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SensiblyNamedMVCdemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int id = 1)
        {
            ViewBag.NumberOfTimes = id;
            return View();
        }

        public ActionResult About(string myName = "", int myNumber = 1)
        {
            ViewBag.Message = "Hey " + myName + " you typed the number " + myNumber + ". why'd you do that?";

            return View();
        }

        public ActionResult Contact(int id = 5)
        {
            ViewBag.Message = "You're trying to contact " + id + "?";

            return View();
        }
    }
}