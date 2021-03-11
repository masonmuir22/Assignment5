using System;
using System.Collections.Generic;
using System.Linq;
namespace Assignment5.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();


        public void AddItem (Books books, int quantity)
        {
            CartLine line = Lines
                .Where(b => b.Books.BookID == books.BookID)
                .FirstOrDefault();

            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    Books = books,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public void RemoveLine(Books books) =>
            Lines.RemoveAll(x => x.Books.BookID == books.BookID);

        //Clear the cart
        public void Clear() => Lines.Clear();

        //calculate the cart total
        public decimal ComputeTotalSum()
        {
            return (decimal)Lines.Sum(e => (e.Books.Price * e.Quantity));
        }

        public class CartLine
        {
            public int CartLineID { get; set; }

            public Books Books { get; set; }

            public int Quantity { get; set; }
        }
   
    }
}
