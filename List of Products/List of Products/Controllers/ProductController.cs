using list_of_products.Models;
using Microsoft.AspNetCore.Mvc;

namespace list_of_products.Controllers
{
    public class ProductController : Controller
    {
        
            public IActionResult Index()
        {
            List<Product> products = new List<Product>
            {
                new Product { id = 1, Name = "Laptop", Price = 999.99, Quantity = 10 },
                new Product { id = 2, Name = "Mobile", Price = 45999.99, Quantity = 25 },
                new Product { id = 3, Name = "HeadPhone", Price = 19999.99, Quantity = 15 }
            };


            return View(products);
        }
    }
}
 