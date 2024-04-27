using Microsoft.AspNetCore.Mvc;

namespace ReservationCoreProject.Areas.Admin.Models.Member.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
