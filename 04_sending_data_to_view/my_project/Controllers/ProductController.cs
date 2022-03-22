using Microsoft.AspNetCore.Mvc;
using my_project.Models;

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
