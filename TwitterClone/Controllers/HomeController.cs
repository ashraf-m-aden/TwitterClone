using Microsoft.AspNetCore.Mvc;
using System.Configuration;
using System.Diagnostics;
using System.Dynamic;
using TwitterClone.Models;

namespace TwitterClone.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}