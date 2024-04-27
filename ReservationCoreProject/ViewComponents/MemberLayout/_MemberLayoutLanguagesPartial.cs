using Microsoft.AspNetCore.Mvc;

namespace ReservationCoreProject.ViewComponents.MemberLayout
{
    public class _MemberLayoutLanguagesPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
