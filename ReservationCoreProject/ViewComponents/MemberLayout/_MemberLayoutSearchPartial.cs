using Microsoft.AspNetCore.Mvc;

namespace ReservationCoreProject.ViewComponents.MemberLayout
{
    public class _MemberLayoutSearchPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
