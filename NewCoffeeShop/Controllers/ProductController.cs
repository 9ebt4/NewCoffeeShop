using Microsoft.AspNetCore.Mvc;
using NewCoffeeShop.Models;

namespace NewCoffeeShop.Controllers
{
    public class ProductController : Controller
    {
        private CoffeeShopDbContext dbContext = new CoffeeShopDbContext();
        public IActionResult Index()
        {
           

            return View(ProductDAL.GetAll());
        }
        public IActionResult Detail(int id)
        {
            
            return View(ProductDAL.GetById(id));
        }
        public IActionResult Categories()
        {

            return View(ProductDAL.GetAllCatergory());
        }
        public IActionResult ProductbyCategory(string category)
        {

            return View(ProductDAL.GetAllByCatergory(category));
        }
    }
}
