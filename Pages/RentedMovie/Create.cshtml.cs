using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MoviesRentalEF.Data;
using MoviesRentalEF.Model;

namespace MoviesRentalEF.Pages.RentedMovie
{
    public class CreateModel : PageModel
    {
        private readonly MoviesRentalEF.Data.MoviesRentalEFContext _context;

        public CreateModel(MoviesRentalEF.Data.MoviesRentalEFContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CustomerId"] = new SelectList(_context.Customer, "CustomerID", "CustomerID");
        ViewData["MovieId"] = new SelectList(_context.Movie, "MovieID", "MovieID");
            return Page();
        }

        [BindProperty]
        public RentedMovies RentedMovies { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.RentedMovies.Add(RentedMovies);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
