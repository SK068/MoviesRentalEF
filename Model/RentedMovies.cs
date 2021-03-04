using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesRentalEF.Model
{
    public class RentedMovies
    {
        public int ID { get; set; }
      
        public string LastName { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
        [ForeignKey("Movie")]
       public int MovieId { get; set; }
        public Movie Movies { get; set; }
        [ForeignKey("Customer")]
       public int CustomerId { get; set; }
        public Customer Customers { get; set; }

       // public ICollection<RentedMovies> RentedMovie { get; set; }
    }
}
