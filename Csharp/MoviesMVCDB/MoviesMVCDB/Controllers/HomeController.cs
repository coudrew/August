using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MoviesMVCDB.Models;

namespace MoviesMVCDB.Controllers
{
    public class HomeController : Controller
    {
        private MovieDBDomainEntities db = new MovieDBDomainEntities();
        // GET: Home
        public ActionResult Index(string movieGenre, string searchString)
        {
            //creating the listbox for selecting by genre
            var genreList = new List<string>();
            var genreQuery = from d in db.Movies
                             orderby d.Genre
                             select d.Genre;
            genreList.AddRange(genreQuery.Distinct());
            ViewBag.movieGenre = new SelectList(genreList);

            //LINQ query to get records from the db
            var movies = from m in db.Movies
                         select m;
            if (!String.IsNullOrEmpty(movieGenre)){
                movies = movies.Where(x => x.Genre == movieGenre);
            }
            //select by title
            if (!String.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(s => s.Title.Contains(searchString));
            }
            return View(movies);
        }

        public ActionResult Details(int? id)
        {
            Movie movie = db.Movies.Find(id);
            return View(movie);
        }

        public ActionResult Edit(int? id)
        {
            Movie movie = db.Movies.Find(id);
            return View(movie);
        }

        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            if (ModelState.IsValid)
            {
                db.Entry(movie).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            } else
            {
                return View(movie);
            }
            
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }
        
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {
           
            Movie movie = db.Movies.Find(id);
            
            db.Movies.Remove(movie);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                db.Movies.Add(movie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(movie);
            }
            
        }
    }
}