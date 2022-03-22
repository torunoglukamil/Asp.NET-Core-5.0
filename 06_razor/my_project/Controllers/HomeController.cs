using Microsoft.AspNetCore.Mvc;

namespace my_project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
