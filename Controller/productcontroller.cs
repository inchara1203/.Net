using Microsoft.AspNetCore.Mvc;
using Razor.Models;

namespace Razor.Controllers
{
    public class productcontroller : Controller
    {
        public IActionResult Index()
        {
            List<product> product = new List<product>()
            {
                new product { Id = 1, Name = "Laptop", Price = 5500, Quanity =2 },
                new product { Id = 2, Name = "Phone", Price = 720000, Quanity =9 },
                new product { Id = 3, Name = "Headphone", Price = 1000, Quanity =2}
                };
                
         return View(product);
         }
    }
}
