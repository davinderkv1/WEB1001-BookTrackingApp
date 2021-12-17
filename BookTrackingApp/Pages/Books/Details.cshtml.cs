using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BookTrackingApp.Data;
using BookTrackingApp.Models;

namespace BookTrackingApp.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly BookTrackingApp.Data.BookTrackingAppContext _context;

        public DetailsModel(BookTrackingApp.Data.BookTrackingAppContext context)
        {
            _context = context;
        }

        public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book = await _context.Book
                .Include(b => b.Category).FirstOrDefaultAsync(m => m.ISBN == id);

            if (Book == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
