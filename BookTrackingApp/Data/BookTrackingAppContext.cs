using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookTrackingApp.Models;

namespace BookTrackingApp.Data
{
    public class BookTrackingAppContext : DbContext
    {
        public BookTrackingAppContext (DbContextOptions<BookTrackingAppContext> options)
            : base(options)
        {
        }

        public DbSet<BookTrackingApp.Models.Book> Book { get; set; }

        public DbSet<BookTrackingApp.Models.Category> Category { get; set; }
    }
}
