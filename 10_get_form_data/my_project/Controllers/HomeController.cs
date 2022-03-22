using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace my_project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetData()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetData(IFormCollection data)
        {
            TempData["value1"] = data["textValue1"];
            TempData["value2"] = data["textValue2"];
            TempData["value3"] = data["textValue3"];
            return View();
        }
    }
}
