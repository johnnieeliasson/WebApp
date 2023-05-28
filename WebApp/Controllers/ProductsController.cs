using Microsoft.AspNetCore.Mvc;
using WebApp.Models.ViewModels;

namespace WebApp.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            var showcase = new ShowcaseViewModel()
            {
                Ingress = "WELCOME TO THE SHOP",
                Title = "Exclusive Chair gold Collection",
                LinkContent = "SHOP NOW",
                LinkUrl = "/products",
                ImageUrl = "images/placeholders/625x647.svg"
            };

            return View(showcase);
        }
        public IActionResult GridIndex()
        {
            var viewModel = new ProductsIndexViewModel
            {
                All = new GridCollectionViewModel
                {
                    Title = "All Products",
                    Categories = new List<string> { "All", "Mobile", "Computers" }
                }
            };
            return View(viewModel);
        }

        public IActionResult Details(int id)
        {
            return View(id);
        }
    }
}
