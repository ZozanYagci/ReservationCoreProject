using Microsoft.AspNetCore.Mvc;

namespace ReservationCoreProject.ViewComponents.MemberDashboard
{
    public class _MemberStatisticPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
