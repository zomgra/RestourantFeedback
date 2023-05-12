using Microsoft.AspNetCore.Mvc;
using RestourantFeedback.Client.Models;
using System.Diagnostics;

namespace RestourantFeedback.Client.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}