using Microsoft.AspNetCore.Mvc;

namespace my_project.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            ViewResult result = View("GetProducts");
            return result;
        }
    }
}
