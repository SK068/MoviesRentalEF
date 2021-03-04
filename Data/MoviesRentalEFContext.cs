using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MoviesRentalEF.Model;

namespace MoviesRentalEF.Data
{
    public class MoviesRentalEFContext : DbContext
    {
        public MoviesRentalEFContext (DbContextOptions<MoviesRentalEFContext> options)
            : base(options)
        {
        }

        public DbSet<MoviesRentalEF.Model.Customer> Customer { get; set; }

        public DbSet<MoviesRentalEF.Model.Movie> Movie { get; set; }

        public DbSet<MoviesRentalEF.Model.RentedMovies> RentedMovies { get; set; }
    }
}
