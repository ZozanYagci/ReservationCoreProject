using Microsoft.AspNetCore.Mvc;

namespace ReservationCoreProject.ViewComponents.MemberLayout
{
    public class _MemberLayoutHeaderContentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
