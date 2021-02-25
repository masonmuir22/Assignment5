using System;
using System.Collections.Generic;

namespace Assignment5.Models.ViewModels
{
    public class BookListViewModel
    {
        public IEnumerable<Books> Books { get; set; }

        public PagingInfo PagingInfo { get; set; }
    }
}
