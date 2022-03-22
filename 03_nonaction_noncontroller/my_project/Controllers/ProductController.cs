using Microsoft.AspNetCore.Mvc;
using my_project.Models;

namespace my_project.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            Product product = new Product();
            product.Id = 1;
            product.ProductName = "Ürün 1";
            product.Quantity = 1000;

            ViewResult result = View("GetProducts");
            return result;
        }
    }
}
