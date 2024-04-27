using Microsoft.AspNetCore.Mvc;

namespace ReservationCoreProject.ViewComponents.AdminDashboard
{
    public class _AdminDashboardHeaderPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
