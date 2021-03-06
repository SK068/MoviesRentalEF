using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesRentalEF.Model
{
   // Add Movie class
    public class Movie
    {
       [Key]// Add Primary key
        public int MovieID { get; set; }
        public int Rating { get; set; }
        public string Title { get; set; }
        public DateTime Year { get; set; }
        public int RentalCost { get; set; }
        public int Copies { get; set; }
        public string Plot { get; set; }
        public string Genre { get; set; }
        //Relation of tables
        public ICollection<RentedMovies> RentedMovies { get; set; }
    }
}
