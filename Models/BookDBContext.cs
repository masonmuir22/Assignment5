using System;

using Microsoft.EntityFrameworkCore;

namespace Assignment5.Models
{
    public class BookDBContext : DbContext
    {
        public BookDBContext (DbContextOptions<BookDBContext> options) : base (options)
        {

        }

        public DbSet<Books> Books { get; set; }
    }
}
