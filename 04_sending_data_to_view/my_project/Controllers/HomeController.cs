using Microsoft.AspNetCore.Mvc;
using my_project.Models;
using System.Collections.Generic;

namespace my_project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product> {
                new Product {Id = 1, ProductName = "Ürün 1", Quantity = 10},
                new Product {Id = 2, ProductName = "Ürün 2", Quantity = 20},
                new Product {Id = 3, ProductName = "Ürün 3", Quantity = 30}
            };

            ViewBag.Products = products; // ViewBag İle Veri Gönderimi

            ViewData["products"] = products; // ViewData İle Veri Gönderimi

            TempData["products"] = products; // TempData İle Veri Gönderimi

            return View(products); // Model Bazlı Veri Gönderimi
        }
    }
}
