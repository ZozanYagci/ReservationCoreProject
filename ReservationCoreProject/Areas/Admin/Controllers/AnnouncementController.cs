using AutoMapper;
using Business.Abstract;
using DTOLayer.DTOs.AnnouncementDTOs;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using ReservationCoreProject.Models;

namespace ReservationCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AnnouncementController : Controller
    {
        private readonly IAnnouncementService _announcementService;
        private readonly IMapper _mapper;
        public AnnouncementController(IAnnouncementService announcementService, IMapper mapper)
        {
            _announcementService = announcementService;
            _mapper = mapper;
        }
        public IActionResult Index()
        {


            //List<Announcement> announcements = _announcementService.TGetList();
            //List<AnnouncementListViewModel> model = new List<AnnouncementListViewModel>();
            //foreach (var item in announcements)
            //{
            //    AnnouncementListViewModel announcementListViewModel = new AnnouncementListViewModel();
            //    announcementListViewModel.Id = item.Id;
            //    announcementListViewModel.Title = item.Title;
            //    announcementListViewModel.Content = item.Content;
            //    model.Add(announcementListViewModel);
            //}


            //Code Refactor

            var values = _mapper.Map<List<AnnouncementListDto>>(_announcementService.TGetList());
            return View(values);
        }

        [HttpGet]
        public ActionResult AddAnnouncement()
        {
            return View();
        }


        [HttpPost]
        public ActionResult AddAnnouncement(AnnouncementAddDto model)
        {
            if(ModelState.IsValid)
            {
                _announcementService.TAdd(new Announcement()
                {
                    Content= model.Content,
                    Title= model.Title,
                    Date=Convert.ToDateTime(DateTime.Now.ToShortDateString())   
                });
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult DeleteAnnouncement(int id) 
        {
            var values=_announcementService.TGetById(id);
            _announcementService.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateAnnouncement(int id)
        {
            var values = _mapper.Map<AnnouncementUpdateDto>(_announcementService.TGetById(id));
            return View(values);    
        }
        [HttpPost]
        public IActionResult UpdateAnnouncement(AnnouncementUpdateDto model)
        {
            if(ModelState.IsValid)
            {
                _announcementService.TUpdate(new Announcement
                {
                    Id = model.Id,
                    Title = model.Title,
                    Content = model.Content,
                    Date = Convert.ToDateTime(DateTime.Now.ToShortDateString())
                });
                return RedirectToAction("Index");
            }
            return View(model);
        }

    }
}
