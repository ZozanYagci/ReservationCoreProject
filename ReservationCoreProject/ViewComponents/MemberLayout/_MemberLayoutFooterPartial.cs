using Microsoft.AspNetCore.Mvc;

namespace ReservationCoreProject.ViewComponents.MemberLayout
{
    public class _MemberLayoutFooterPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
