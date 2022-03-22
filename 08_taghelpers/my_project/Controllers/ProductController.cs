using Microsoft.AspNetCore.Mvc;

namespace my_project.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
