using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MoviesRentalEF.Data;
using MoviesRentalEF.Model;

namespace MoviesRentalEF.Pages.RentedMovie
{
    public class EditModel : PageModel
    {
        private readonly MoviesRentalEF.Data.MoviesRentalEFContext _context;

        public EditModel(MoviesRentalEF.Data.MoviesRentalEFContext context)
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
                .Include(r => r.Movie).FirstOrDefaultAsync(m => m.ID == id);

            if (RentedMovies == null)
            {
                return NotFound();
            }
           ViewData["CustomerId"] = new SelectList(_context.Customer, "CustomerID", "CustomerID");
           ViewData["MovieId"] = new SelectList(_context.Movie, "MovieID", "MovieID");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(RentedMovies).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RentedMoviesExists(RentedMovies.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool RentedMoviesExists(int id)
        {
            return _context.RentedMovies.Any(e => e.ID == id);
        }
    }
}
