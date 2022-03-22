using Microsoft.AspNetCore.Mvc;
using my_project.Models;

namespace my_project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Product product = new Product()
            {
                ProductName = "Ürün 0"
            };
            return View(product);
        }

        // default -> [HttpGet]
        public IActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateProduct(string textProductName, int textQuantity)
        {
            TempData["productName"] = textProductName;
            TempData["quantity"] = textQuantity;
            return View();
        }

        public IActionResult CreateProduct2()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateProduct2(Product product)
        {
            TempData["productName"] = product.ProductName;
            TempData["quantity"] = product.Quantity;
            return View();
        }
    }
}
