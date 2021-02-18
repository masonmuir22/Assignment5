﻿using System;
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
                        Title = "Les Miserables",
                        Author = "Victor Hugo",
                        Publisher = "Signet",
                        ISBN = "978 - 0451419439",
                        Category = "",
                        Price = "$9.95"
                    },

                    new Books
                    {
                        Title = "Team of Rivals",
                        Author = "Doris Kearns Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = "978 - 0743270755",
                        Category = "Non-Fiction, Biography",
                        Price = "$14.58"
                    },

                    new Books
                    {
                        Title = "The Snowball",
                        Author = "Alice Schroeder",
                        Publisher = "Bantam",
                        ISBN = "978 - 0553384611",
                        Category = "Non-Fiction, Biography",
                        Price = "$21.54"
                    },

                    new Books
                    {
                        Title = "American Ulysses",
                        Author = "Ronald C. White",
                        Publisher = "Random House",
                        ISBN = "978 - 0812981254",
                        Category = "Non - Fiction, Biography",
                        Price = "$11.61"
                    },

                    new Books
                    {
                        Title = "Unbroken",
                        Author = "Laura Hillenbrand",
                        Publisher = "Random House",
                        ISBN = "978 - 0812974492",
                        Category = "Non - Fiction, Historical",
                        Price = "$13.33"
                    },

                    new Books
                    {
                        Title = "The Great Train Robbery",
                        Author = "Michael Crichton",
                        Publisher = "Vintage",
                        ISBN = "978 - 0804171281",
                        Category = "Fiction, Historical Fiction",
                        Price = "$15.95"
                    },

                    new Books
                    {
                        Title = "Deep Work",
                        Author = "Cal Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978 - 1455586691",
                        Category = "Non - Fiction, Self - Help",
                        Price = "$14.99"
                    },

                    new Books
                    {
                        Title = "It's Your Ship",
                        Author = "Michael Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978 - 1455523023",
                        Category = "Non - Fiction, Self - Help",
                        Price = "$21.66"
                    },


                    new Books
                    {
                        Title = "The Virgin Way",
                        Author = "Richard Branson",
                        Publisher = "Portfolio",
                        ISBN = "978 - 1591847984",
                        Category = "Non - Fiction, Business",
                        Price = "$29.16"
                    },


                    new Books
                    {
                        Title = "Sycamore Row",
                        Author = "Row John Grisham",
                        Publisher = "Bantam",
                        ISBN = "978 - 0553393613",
                        Category = "Fiction, Thrillers",
                        Price = "$15.03"
                    }

                       

                    );


                context.SaveChanges();        

                   
                     
            }
        }
    }
}
