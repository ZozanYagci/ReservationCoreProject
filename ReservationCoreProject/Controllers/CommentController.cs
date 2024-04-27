using Business.Concrete;
using DataAccess.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace ReservationCoreProject.Controllers
{
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());
        private readonly UserManager<AppUser> _userManager;
        public CommentController(UserManager<AppUser> userManager)
        {
                _userManager = userManager;
        }

        [HttpGet]
        public async Task< PartialViewResult> AddComment(int id)
        {
            ViewBag.destId = id;
            var value = await _userManager.FindByNameAsync(User.Identity.Name);

            ViewBag.userId = value.Id;
            return PartialView();
        }
        [HttpPost]
        public IActionResult AddComment(Comment p)
        {
            p.CommentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.CommentState = true;
            p.DestinationId = 3;
            commentManager.TAdd(p);
            return RedirectToAction("Index", "Destination");
        }
    }
}
