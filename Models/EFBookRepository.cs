using System;
using System.Linq;

namespace Assignment5.Models
{
    public class EFBookRepository : IBookRepository
    {
        private BookDBContext _context;

        //Constructor
        public EFBookRepository (BookDBContext context)
        {
            _context = context;
        }

        public IQueryable<Books> Books => _context.Books;
    }
}
