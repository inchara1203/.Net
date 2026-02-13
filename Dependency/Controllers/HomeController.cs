using DependencyInjection.Models;
using DependencyInjection.sevices;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMyService _myService;
       

        public HomeController(IMyService service )
        {
            _myService = service;
        }

        public IActionResult Index()
        {
           string message = _myService.GetMessage();
            return Content(message);
        }

    
    }
}
