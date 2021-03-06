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
    public class DetailsModel : PageModel
    {
        private readonly MoviesRentalEF.Data.MoviesRentalEFContext _context;

        public DetailsModel(MoviesRentalEF.Data.MoviesRentalEFContext context)
        {
            _context = context;
        }

        public RentedMovies RentedMovies { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            RentedMovies = await _context.RentedMovies
                .Include(r => r.Customers)
                .Include(r => r.Movie).FirstOrDefaultAsync(m => m.ID == id);

            if (RentedMovies == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
