using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using viddly.Models;
using viddly.ViewModels;

namespace viddly.Controllers
{
    public class MovieController : Controller
    {

        #region Basic Handler view-Controller and controller-view in asp net mvc5
        // GET: Movie
        public ViewResult Random()
        {
            var movie = new Movie() { Name = "Shrek!!" };


            #region Not Use ViewBag and ViewData
            /*ViewBag and ViewData is not good pratice for programmers .Net
             because the structures of theirs codes is not clean and manuntuince*/
            //ViewBag.Movie = movieViewModel;
            //ViewData["Movie"] = movieViewModel;
            #endregion

            #region Internal view string type with viewResult when we return "View(object value)"
            //var viewResult = new ViewResult();
            //viewResult.ViewData.Model = movieViewModel;
            //return viewResult;
            #endregion

            #region Types return for view
            //return Content("Hello World");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
            #endregion

            return View(movie);



        }



        public ContentResult Edit(int id)
        {

            return Content("Id=" + id);
        }


        //Movies
        public ContentResult Index(int? pageIndex, string sortBy)
        {

            if (pageIndex.HasValue)
                pageIndex = 1;
            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "name for sort by";

            return Content(String.Format("PageIndex={0}&sortby={1}", pageIndex, sortBy));
        }

        #endregion


        #region Using atribute routing is better then config routes in routeConfig
        //Month is byte because the max value possible is 12 soon is good pratice this parameter isn't int
        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ContentResult ByReleaseDate(int year, byte month)
        {
            return Content(year + "/" + month);
        }
        #endregion


        public ActionResult RandomMovieAndCustomersMovies()
        {
            var movie = new MovieViewModel { Id = 4, Name = "Final Fantasy!!!!" };
            var customers = new List<CustomerViewModel>
            {
                 new CustomerViewModel {  Id = 10, Nome="Customer 10" },
                 new CustomerViewModel {  Id = 15, Nome="Customer 15" }
            };


            var viewModel = new RandomMovieViewModel { Movie = movie, Customers = customers };

            return View(viewModel);
        }

    }
}