using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.EntityFramework;

using Microsoft.AspNetCore.Mvc;

namespace ReservationCoreProject.ViewComponents.Comment
{
    public class _CommentListPartial:ViewComponent
    {

        CommentManager commentManager = new CommentManager(new EfCommentDal());
        Context context= new Context();
        public IViewComponentResult Invoke(int id)
        {
            ViewBag.commentCount= context.Comments.Where(x=>x.Id==id).Count();
            var comments=commentManager.TGetListCommentWithDestinationAndUser(id);
            return View(comments);
        }
    }
}
