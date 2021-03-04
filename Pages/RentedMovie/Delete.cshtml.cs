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
    public class DeleteModel : PageModel
    {
        private readonly MoviesRentalEF.Data.MoviesRentalEFContext _context;

        public DeleteModel(MoviesRentalEF.Data.MoviesRentalEFContext context)
        {
            _context = context;
        }

        [BindProperty]
        public RentedMovies RentedMovies { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            RentedMovies = await _context.RentedMovies
                .Include(r => r.Customers)
                .Include(r => r.Movies).FirstOrDefaultAsync(m => m.ID == id);

            if (RentedMovies == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            RentedMovies = await _context.RentedMovies.FindAsync(id);

            if (RentedMovies != null)
            {
                _context.RentedMovies.Remove(RentedMovies);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
