using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCRecords.Models;

namespace MVCRecords.Controllers
{
    public class HomeController : Controller
    {
        List<Album> albums = new List<Album>();
        // GET: Home
        public ActionResult Index()
        {
            Album nihil = new Album("Nihil", "KMFDM", "CD", 9.99m);
            albums.Add(nihil);
            Album empire = new Album("Evil Empire", "rage against the machine", "CD", 9.99m);
            albums.Add(empire);
            Album ultravisitor = new Album("Ultravisitor", "Squarepusher", "CD", 15.99m);
            albums.Add(ultravisitor);
            Album drukqs = new Album("drukqs", "Aphex Twin", "CD", 23.99m);
            albums.Add(drukqs);
            Album deadringer = new Album("Deadringer", "RJD2", "CD", 9.99m);
            albums.Add(deadringer);
            return View(albums);
        }
    }
}