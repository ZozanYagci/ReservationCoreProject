using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ReservationCoreProject.ViewComponents.MemberDashboard
{
    public class _LastDestinationsPartial:ViewComponent
    {
        private readonly IDestinationService _destinationService;
        public _LastDestinationsPartial(IDestinationService destinationService)
        {
                _destinationService = destinationService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _destinationService.TGetLast4Destination();
            return View(values);
        }
    }
}
