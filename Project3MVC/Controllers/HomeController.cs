using Microsoft.AspNetCore.Mvc;
using Project3MVC.Models;
using System.Diagnostics;

namespace Project3MVC.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
