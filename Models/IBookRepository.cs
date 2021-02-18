﻿using System;
using System.Linq;

namespace Assignment5.Models
{
    public interface IBookRepository
    {
        IQueryable<Books> Books { get; }
    }
}
