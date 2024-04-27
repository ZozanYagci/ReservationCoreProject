using Microsoft.AspNetCore.Mvc;

namespace ReservationCoreProject.ViewComponents.AdminDashboard
{
    public class _DashboardBannerPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
