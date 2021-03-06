using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesRentalEF.Model
{
    //add Customer class
    public class Customer
    { 
        [Key] //Add primary key
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
        //Add Relation of tables
        public ICollection<RentedMovies> RentedMovies { get; set; }
    }
}
