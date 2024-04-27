using Microsoft.AspNetCore.Mvc;

namespace ReservationCoreProject.Controllers
{
    [Area("Member")]
    public class InformationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
