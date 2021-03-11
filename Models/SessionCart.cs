using System;
using System.Text.Json.Serialization;
using Assignment5.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
namespace Assignment5.Models
{
    public class SessionCart : Cart
    {
        public static Cart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;
            SessionCart Cart = session?.GetJson<SessionCart>("Cart")
                ?? new SessionCart();
            Cart.Session = session;
            return Cart;
        }
        [JsonIgnore]
        public ISession Session { get; set; }
        public virtual void AddItem(Books books, int quantity)
        {
            base.AddItem(books, quantity);
            Session.SetJson("Cart", this);
        }
        public virtual void RemoveLine(Books books)
        {
            base.RemoveLine(books);
            Session.SetJson("Cart", this);
        }
        public virtual void Clear()
        {
            base.Clear();
            Session.Remove("Cart");
        }
    }
}
