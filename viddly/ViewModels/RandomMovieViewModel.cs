using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace viddly.ViewModels
{
    public class RandomMovieViewModel
    {
        public MovieViewModel Movie { get; set; }
        public List<CustomerViewModel> Customers { get; set; }

    }
}