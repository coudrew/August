using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCMovies.Models;

namespace MVCMovies.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        private MovieDBDomainEntities db = new MovieDBDomainEntities();
        public ActionResult Index()
        {
            //LINQ query to get records
            var movie = from m in db.Movies
                         select m;
            return View();
        }
    }
}