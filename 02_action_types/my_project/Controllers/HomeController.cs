using Microsoft.AspNetCore.Mvc;
using my_project.Models;

namespace my_project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // 1) JsonResult
            /*JsonResult result = Json(new Product
            {
                Id = 5,
                ProductName = "Ürün 5",
                Quantity = 100,
            });*/

            // 2) EmptyResult
            //EmptyResult result = new EmptyResult();

            // 3) ContentResult
            ContentResult result = Content("İçerik");

            return result;
        }
    }
}
