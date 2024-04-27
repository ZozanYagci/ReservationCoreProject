using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ReservationCoreProject.ViewComponents.Default
{
    public class _PopularDestinationPartial:ViewComponent
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        public IViewComponentResult Invoke()
        {
            var destinations = destinationManager.TGetList();
            return View(destinations);
        }
    }
}
