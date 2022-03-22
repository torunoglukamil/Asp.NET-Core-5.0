using Microsoft.AspNetCore.Mvc;

namespace my_project.Controllers
{
    [NonController] // HomeController dışarıdan gelen isteği karşılamaz.
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            MyMethod();
            return View();
        }

        [NonAction] // MyMethod dışarıdan gelen isteği karşılamaz.
        public void MyMethod()
        {
            //...
        }
    }
}
