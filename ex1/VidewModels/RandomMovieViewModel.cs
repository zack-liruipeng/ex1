using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ex1.Models;

namespace ex1.VidewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}