using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ex1.Models;
using ex1.VidewModels;

namespace ex1.Controllers
{
    public class MoviesController : Controller
    {

        public ViewResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        public IEnumerable<Movie> GetMovies ()
        {
            return new List<Movie>
            {
               new Movie { Id = 1, Name = "Shrek" },
               new Movie { Id = 2, Name = "Wall-e" }
            };
        }

        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie()
            {
                Name = "newMovie"
            };
            var customers = new List<Customer>
            {
                new Customer { Name = "c1"},
                new Customer { Name = "c2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            // return Content("hello world"); just return hello world
            // return HTTPNotFound(); return 404 error
            // return new EmptyResult(); return nothing
          //  return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
            return View(viewModel);
        }

        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year+"/"+ month);
        }
       
    }
}