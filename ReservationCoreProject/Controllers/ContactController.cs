﻿using AutoMapper;
using Business.Abstract;
using Business.Concrete;
using DataAccess.EntityFramework;
using DTOLayer.DTOs.ContactDTOs;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ReservationCoreProject.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        private readonly IContactUsService _contactUsService;
        private readonly IMapper _mapper;
        public ContactController(IContactUsService contactUsService, IMapper mapper)
        {
            _contactUsService = contactUsService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(SendMessageDto model)
        {
            if (ModelState.IsValid)
            {
                _contactUsService.TAdd(new ContactUs()
                {
                    MessageBody=model.MessageBody,
                    Mail=model.Mail,
                    MessageStatus=true,
                    Name=model.Name,
                    Subject=model.Subject,
                    MessageDate=Convert.ToDateTime(DateTime.Now.ToShortDateString()),
                });
                return RedirectToAction("Index", "Default");
            }
            return View();
        }
    }
}
