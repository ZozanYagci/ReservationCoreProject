﻿using Microsoft.AspNetCore.Mvc;

namespace ReservationCoreProject.ViewComponents.Default
{
    public class _SliderPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
