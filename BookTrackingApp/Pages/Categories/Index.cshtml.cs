using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BookTrackingApp.Data;
using BookTrackingApp.Models;

namespace BookTrackingApp.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly BookTrackingApp.Data.BookTrackingAppContext _context;

        public IndexModel(BookTrackingApp.Data.BookTrackingAppContext context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; }

        public async Task OnGetAsync()
        {
            Category = await _context.Category.ToListAsync();
        }
    }
}
