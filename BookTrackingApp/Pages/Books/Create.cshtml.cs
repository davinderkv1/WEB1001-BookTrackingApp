using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BookTrackingApp.Data;
using BookTrackingApp.Models;

namespace BookTrackingApp.Pages.Books
{
    public class CreateModel : PageModel
    {
        private readonly BookTrackingApp.Data.BookTrackingAppContext _context;

        public CreateModel(BookTrackingApp.Data.BookTrackingAppContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CategoryId"] = new SelectList(_context.Set<Category>(), "CategoryId", "NameToken");
            return Page();
        }

        [BindProperty]
        public Book Book { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Book.Add(Book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
