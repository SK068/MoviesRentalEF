﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly MoviesRentalEF.Data.MoviesRentalEFContext _context;

        public DetailsModel(MoviesRentalEF.Data.MoviesRentalEFContext context)
        {
            _context = context;
        }

        public Customer Customer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer = await _context.Customer.FirstOrDefaultAsync(m => m.CustomerID == id);

            if (Customer == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
