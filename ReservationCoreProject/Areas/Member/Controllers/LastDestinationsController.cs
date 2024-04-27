using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ReservationCoreProject.Areas.Member.Controllers
{
    [Area("Members")]
    public class LastDestinationsController : Controller
    {
        private readonly IDestinationService _destinationService;
        public LastDestinationsController(IDestinationService destinationService)
        {
                _destinationService = destinationService;
        }
        public IActionResult Index()
        {
            var values = _destinationService.TGetLast4Destination();
            return View(values);
        }
    }
}
