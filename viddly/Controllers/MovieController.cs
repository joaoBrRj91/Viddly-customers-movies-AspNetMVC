using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using viddly.Models;

namespace viddly.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Random()
        {
            var movieViewModel = new MovieViewModel() { Name="Shrek!!" };
            return View(movieViewModel);
        }
    }
}