using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment5.Infrastructure;
using Assignment5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Assignment5.Pages
{
    public class CartModel : PageModel
    {

        private IBookRepository repository;

        //constructor
        public CartModel(IBookRepository repo)
        {
            repository = repo;
 
        }

        //properties
        public Cart Cart { get; set;}

        public string ReturnUrl { get; set; }

        //methods
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
        }

        //Adds the book to the cart
        public IActionResult OnPost(long BookID, string returnUrl)
        {
            Books books = repository.Books.FirstOrDefault(b => b.BookID == BookID);

            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();

            Cart.AddItem(books, 1);

            HttpContext.Session.SetJson("cart", Cart);

            return RedirectToPage(new { returnUrl = returnUrl });
        }

        //Removes the book from the cart
        public IActionResult OnPostRemove(long bookId, string returnUrl)
        {
            Books books = repository.Books.FirstOrDefault(b => b.BookID == bookId);

            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();

            Cart.RemoveLine(books);

            HttpContext.Session.SetJson("cart", Cart);

            return RedirectToPage(new { returnUrl = returnUrl });

        }
    }
}
