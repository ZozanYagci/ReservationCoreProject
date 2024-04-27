using Microsoft.AspNetCore.Mvc;

namespace ReservationCoreProject.ViewComponents.AdminDashboard
{
    public class _AdminGuideListPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
