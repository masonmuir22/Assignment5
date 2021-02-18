using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Assignment5.Models
{
    public class SeedData
    {
        public static void Blah (IApplicationBuilder application)
        {
            BookDBContext context = application.ApplicationServices.
                CreateScope().ServiceProvider.GetRequiredService<BookDBContext>();

            if(context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if(!context.Books.Any())
            {
                context.Books.AddRange(
                    new Books
                    {
                        BookID = 1,
                        Title = "Les Miserables",
                        AuthorFirst = "Victor",
                        AuthorLast = "Hugo",
                        Publisher = "Signet",
                        ISBN = "978 - 0451419439",
                        Class = "Fiction",
                        Category = "Classic",
                        Price = "$9.95"
                    },

                    new Books
                    {
                        BookID = 2,
                        Title = "Team of Rivals",
                        AuthorFirst = "Doris",
                        AuthorMiddle = "Kearns",
                        AuthorLast = "Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = "978 - 0743270755",
                        Class = "Non-Fiction",
                        Category = "Biography",
                        Price = "$14.58"
                    },

                    new Books
                    {
                        BookID = 3,
                        Title = "The Snowball",
                        AuthorFirst = "Alice ",
                        AuthorLast = "Schroeder",
                        Publisher = "Bantam",
                        ISBN = "978 - 0553384611",
                        Class = "Non-Fiction",
                        Category = "Biography",
                        Price = "$21.54"
                    },

                    new Books
                    {
                        BookID = 4,
                        Title = "American Ulysses",
                        AuthorFirst = "Ronald",
                        AuthorMiddle = "C.",
                        AuthorLast = "White",
                        Publisher = "Random House",
                        ISBN = "978 - 0812981254",
                        Class = "Non-Fiction",
                        Category = "Biography",
                        Price = "$11.61"
                    },

                    new Books
                    {
                        BookID = 5,
                        Title = "Unbroken",
                        AuthorFirst = "Laura ",
                        AuthorLast = "Hillenbrand",
                        Publisher = "Random House",
                        ISBN = "978 - 0812974492",
                        Class = "Non-Fiction",
                        Category = "Historical",
                        Price = "$13.33"
                    },

                    new Books
                    {
                        BookID = 6,
                        Title = "The Great Train Robbery",
                        AuthorFirst = "Michael",
                        AuthorLast = "Crichton",
                        Publisher = "Vintage",
                        ISBN = "978 - 0804171281",
                        Class = "Fiction",
                        Category = "Historical Fiction",
                        Price = "$15.95"
                    },

                    new Books
                    {
                        BookID = 7,
                        Title = "Deep Work",
                        AuthorFirst = "Cal",
                        AuthorLast = "Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978 - 1455586691",
                        Class = "Non-Fiction",
                        Category = "Self - Help",
                        Price = "$14.99"
                    },

                    new Books
                    {
                        BookID = 8,
                        Title = "It's Your Ship",
                        AuthorFirst = "Michael ",
                        AuthorLast = "Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978 - 1455523023",
                        Class = "Non-Fiction",
                        Category = "Self - Help",
                        Price = "$21.66"
                    },


                    new Books
                    {
                        BookID = 9,
                        Title = "The Virgin Way",
                        AuthorFirst = "Richard",
                        AuthorLast = "Branson",
                        Publisher = "Portfolio",
                        ISBN = "978 - 1591847984",
                        Class = "Non-Fiction",
                        Category = "Business",
                        Price = "$29.16"
                    },


                    new Books
                    {
                        BookID = 10,
                        Title = "Sycamore Row",
                        AuthorFirst = "Row",
                        AuthorMiddle = "John",
                        AuthorLast = "Grisham",
                        Publisher = "Bantam",
                        ISBN = "978 - 0553393613",
                        Class = "Fiction",
                        Category = "Thrillers",
                        Price = "$15.03"
                    }

                       

                    );


                context.SaveChanges();        

                   
                     
            }
        }
    }
}
