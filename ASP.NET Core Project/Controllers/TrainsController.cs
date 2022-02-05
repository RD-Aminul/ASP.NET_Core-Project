using ASP.NET_Core_Project.Models;
using ASP.NET_Core_Project.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Project.Controllers
{
    public class TrainsController : Controller
    {
        private IPassengerRepository _passengerRepository;
        public TrainsController(IPassengerRepository passengerRepository)
        {
            this._passengerRepository = passengerRepository;
        }

        public IActionResult Index()
        {
            return View(_passengerRepository.GetAllTrain());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Train obj)
        {
            if (ModelState.IsValid)
            {
                Train train = new Train
                {
                    TrainName = obj.TrainName,
                };
                _passengerRepository.SaveTrain(train);
            }
            return RedirectToAction("Index", _passengerRepository.GetAllTrain());
        }
    }
}
