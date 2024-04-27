using Microsoft.AspNetCore.Mvc;

namespace ReservationCoreProject.ViewComponents.MemberDashboard
{
    public class _PlatformSettingPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
