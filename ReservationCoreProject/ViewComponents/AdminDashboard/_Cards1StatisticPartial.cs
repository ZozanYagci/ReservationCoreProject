﻿using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ReservationCoreProject.ViewComponents.AdminDashboard
{
    public class _Cards1StatisticPartial:ViewComponent
    {
        Context c= new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.Destinations.Count();
            ViewBag.v2=c.Users.Count();
            return View();
        }
    }
}
