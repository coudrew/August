using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShowInvite.Models;

namespace ShowInvite.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            return View();
        }

        public ViewResult RsvpForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult RsvpForm(GuestResponse response)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks", response);
            }
            else
            {
                return View();
            }
        }
    }
}