using Microsoft.AspNetCore.Mvc;
using my_project.Models;

namespace my_project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Mesaj = "Mesaj içeriği";

            Product product = new Product()
            {
                Id = 1,
                ProductName = "Ürün 1",
                Quantity = 10
            };

            return View(product);
        }
    }
}
