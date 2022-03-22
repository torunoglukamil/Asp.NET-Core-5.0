using Microsoft.AspNetCore.Mvc;
using my_project.Models;
using my_project.Models.ViewModel;


namespace my_project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index2()
        {
            return View();
        }

        public IActionResult GetProducts()
        {
            Product product = new Product()
            {
                Id = 1,
                ProductName = "Ürün 1",
                Quantity = 10
            };

            User user = new User()
            {
                Id = 1,
                Name = "Mehmet Kamil",
                Surname = "Torunoğlu"
            };

            UserProduct userProduct = new UserProduct() // ViewModel ile Nesne Gönderimi
            {
                User = user,
                Product = product
            };

            return View(userProduct);
        }

        public IActionResult GetProducts2()
        {
            Product product = new Product()
            {
                Id = 1,
                ProductName = "Ürün 1",
                Quantity = 10
            };

            User user = new User()
            {
                Id = 1,
                Name = "Mehmet Kamil",
                Surname = "Torunoğlu"
            };

            var userProduct = (user, product); // Tuple ile Nesne Gönderimi

            return View(userProduct);
        }
    }
}
