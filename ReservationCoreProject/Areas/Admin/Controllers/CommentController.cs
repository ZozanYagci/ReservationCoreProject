using Business.Abstract;
using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ReservationCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CommentController : Controller
    {
        //Refactoring

        //CommentManager commentManager = new CommentManager(new EfCommentDal());

        private readonly ICommentService _commentService;
        public CommentController(ICommentService commentService)
        {
                _commentService = commentService;
        }
        public IActionResult Index()
        {
            //var values = commentManager.TGetListCommentWithDestination();
            var values = _commentService.TGetListCommentWithDestination();
            return View(values);
        }

        public IActionResult DeleteComment(int id)
        {
            var values=_commentService.TGetById(id);
            _commentService.TDelete(values);
            return RedirectToAction("Index");
        }
    }
}
