using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MoviesRentalEF.Data;
using MoviesRentalEF.Model;

namespace MoviesRentalEF.Pages.Customers
{
    public class IndexModel : PageModel
    {
        private readonly MoviesRentalEF.Data.MoviesRentalEFContext _context;

        public IndexModel(MoviesRentalEF.Data.MoviesRentalEFContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; }

        public async Task OnGetAsync()
        {
            Customer = await _context.Customer.ToListAsync();
        }
    }
}
