using Microsoft.AspNetCore.Mvc;

namespace ReservationCoreProject.ViewComponents.MemberLayout
{
    public class _MemberLayoutNavbarPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
