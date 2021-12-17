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
    public class IndexModel : PageModel
    {
        private readonly BookTrackingApp.Data.BookTrackingAppContext _context;

        public IndexModel(BookTrackingApp.Data.BookTrackingAppContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }

        public async Task OnGetAsync()
        {
            Book = await _context.Book
                .Include(b => b.Category).ToListAsync();
        }
    }
}
