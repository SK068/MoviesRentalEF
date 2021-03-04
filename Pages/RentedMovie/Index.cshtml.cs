using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MoviesRentalEF.Data;
using MoviesRentalEF.Model;

namespace MoviesRentalEF.Pages.RentedMovie
{
    public class IndexModel : PageModel
    {
        private readonly MoviesRentalEF.Data.MoviesRentalEFContext _context;

        public IndexModel(MoviesRentalEF.Data.MoviesRentalEFContext context)
        {
            _context = context;
        }

        public IList<RentedMovies> RentedMovies { get;set; }

        public async Task OnGetAsync()
        {
            RentedMovies = await _context.RentedMovies
                .Include(r => r.Customers)
                .Include(r => r.Movies).ToListAsync();
        }
    }
}
