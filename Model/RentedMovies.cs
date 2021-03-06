using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesRentalEF.Model
{
    //Decalre movies name
    public enum Movies
    {
        ABCD,Krish,War,Don,Nayak
    }
    //Add RentedMovies class
    public class RentedMovies
    {
        public int ID { get; set; }
      
       //Add Foreign key to join movie table with rented movie table
        [ForeignKey("Movie")]
       public int MovieId { get; set; }
        public Movie Movie { get; set; }
        //Add Foreign key to join customer table with rented movie table 
        [ForeignKey("Customer")]
       
        public int CustomerId { get; set; }
        public Customer Customers { get; set; }
        public Movies? Movies { get; set; }

       
    }
}
