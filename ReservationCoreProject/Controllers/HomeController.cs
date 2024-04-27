using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ReservationCoreProject.Models;

namespace ReservationCoreProject.Controllers
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
            _logger.LogInformation("Index sayfasý çaðrýldý");
            _logger.LogError("Error log çaðrýldý");
            return View();
        }

        public IActionResult Privacy()
        {
            DateTime d= Convert.ToDateTime(DateTime.Now.ToLongDateString());
            _logger.LogInformation(d+ "Privacy sayfasý çaðrýldý");
            return View();
        }

        public IActionResult Test()
        {
            _logger.LogInformation("Test sayfasý çaðrýldý");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
