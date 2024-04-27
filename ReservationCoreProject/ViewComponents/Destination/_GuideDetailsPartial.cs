﻿using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ReservationCoreProject.ViewComponents.Destination
{
    public class _GuideDetailsPartial:ViewComponent
    {
        private readonly IGuideService _guideService;
        public _GuideDetailsPartial(IGuideService guideService)
        {
                _guideService = guideService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _guideService.TGetById(1);
            return View(values);
        }
    }
}
