
using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ReservationCoreProject.ViewComponents.MemberDashboard
{
    public class _GuideListPartial:ViewComponent
    {
        GuideManager guideManager= new GuideManager(new EfGuideDal());
        public IViewComponentResult Invoke()
        {
            var guides = guideManager.TGetList();
            return View(guides);
        }
    }
}
