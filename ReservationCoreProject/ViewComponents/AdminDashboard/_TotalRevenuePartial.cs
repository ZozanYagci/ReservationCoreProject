using Microsoft.AspNetCore.Mvc;

namespace ReservationCoreProject.ViewComponents.AdminDashboard
{
    public class _TotalRevenuePartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
