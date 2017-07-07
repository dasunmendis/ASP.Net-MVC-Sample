using System.Collections.Generic;

namespace MVC_Sample.Models
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }   
    }
}