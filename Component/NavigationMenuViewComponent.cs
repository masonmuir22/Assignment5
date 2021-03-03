using System;
using Microsoft.AspNetCore.Mvc;
using Assignment5.Models;
using System.Linq;

namespace Assignment5.Component

{
    public class NavigationMenuViewComponent : ViewComponent
    {

        private IBookRepository repository;

        public NavigationMenuViewComponent(IBookRepository r)
        {
            repository = r;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];

            return View(repository.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x=>x)

                );
                
        }
    }
}
