﻿using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ReservationCoreProject.Models;

namespace ReservationCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CityController : Controller
    {
        private readonly IDestinationService _destinationService;
        public CityController(IDestinationService destinationService)
        {
                _destinationService = destinationService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CityList()
        {
            var jsonCity=JsonConvert.SerializeObject(_destinationService.TGetList());
            return View(jsonCity);
        }
        [HttpPost]
        public IActionResult AddCityDestination(Destination destination)
        {
            destination.Status = true;
            _destinationService.TAdd(destination);
            var values=JsonConvert.SerializeObject(destination);
            return Json(values);
        }

        public IActionResult GetById(int Id)
        {
            var values=_destinationService.TGetById(Id);
            var jsonValues=JsonConvert.SerializeObject(values);
            return Json(jsonValues); 
        }

        public IActionResult DeleteCity(int id)
        {
            var values = _destinationService.TGetById(id);
            _destinationService.TDelete(values);
            return NoContent();
        }
        public IActionResult UpdateCity(Destination destination)
        {
            _destinationService.TUpdate(destination);
            var v=JsonConvert.SerializeObject(destination);
            return Json(v); 
        }
    }
}
