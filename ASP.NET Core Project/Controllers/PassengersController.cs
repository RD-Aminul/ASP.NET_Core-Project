using ASP.NET_Core_Project.Models;
using ASP.NET_Core_Project.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Project.Controllers
{
    public class PassengersController : Controller
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        private IPassengerRepository _passengerRepository;
        public PassengersController(IPassengerRepository passengerRepository, IWebHostEnvironment hostingEnvironment)
        {
            this._passengerRepository = passengerRepository;
            this._hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Index(string searchText = "", int pg = 1)
        {
            List<Passsenger> list = _passengerRepository.GetAllPassenger().ToList();

            //for Searching
            if (searchText != "" && searchText != null)
            {
                list = _passengerRepository.GetAllPassenger().Where(p => p.PassengerName.Contains(searchText)).ToList();
            }
            else
            {
                list = _passengerRepository.GetAllPassenger().Where(p => p.PassengerName.Contains(searchText)).ToList();
            }

            //forPaging
            const int pageSize = 3;
            if (pg < 1)
            {
                pg = 1;
            }
            int recsCount = list.Count();
            var pager = new Pager(recsCount, pg, pageSize);
            int recSkip = (pg - 1) * pageSize;
            var data = list.Skip(recSkip).Take(pager.PageSize).ToList();
            this.ViewBag.Pager = pager;

            return View(data);
        }

        public IActionResult Create()
        {
            ViewBag.Trains = _passengerRepository.GetAllTrain();
            ViewBag.Routes = _passengerRepository.GetAllRoute();
            ViewBag.Classes = _passengerRepository.GetAllClass();
            return View();
        }

        [HttpPost]
        public IActionResult Create(PassengerViewModel obj)
        {
            if (ModelState.IsValid)
            {
                string unqueFileName = ProcessFileUpload(obj);
                Passsenger passenger = new Passsenger
                {
                    PassengerID = obj.PassengerID,
                    PassengerName = obj.PassengerName,
                    PassengerEmail = obj.PassengerEmail,
                    PassengerPhone = obj.PassengerPhone,
                    JourneyDate = obj.JourneyDate,
                    TrainID = obj.TrainID,
                    RouteID = obj.RouteID,
                    ClassID = obj.ClassID,
                    Fee = obj.Fee,
                    PhotoPath = unqueFileName
                };
                _passengerRepository.SavePassenger(passenger);
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Trains = _passengerRepository.GetAllTrain();
                ViewBag.Routes = _passengerRepository.GetAllRoute();
                ViewBag.Classes = _passengerRepository.GetAllClass();
                return View();
            }
        }

        private string ProcessFileUpload(PassengerViewModel obj)
        {
            string unqueFileName = null;
            if (obj.Photo != null)
            {
                string uploadFolder = Path.Combine(_hostingEnvironment.WebRootPath, "Images");
                unqueFileName = Guid.NewGuid().ToString() + "_" + obj.Photo.FileName;
                string filePath = Path.Combine(uploadFolder, unqueFileName);
                using (var FileStream = new FileStream(filePath, FileMode.Create))
                {
                    obj.Photo.CopyTo(FileStream);
                }
            }
            return unqueFileName;
        }
        public IActionResult Edit(int id)
        {
            ViewBag.Trains = _passengerRepository.GetAllTrain();
            ViewBag.Routes = _passengerRepository.GetAllRoute();
            ViewBag.Classes = _passengerRepository.GetAllClass();
            Passsenger psngr = _passengerRepository.GetPassengerById(id);
            PassengerViewModel viewModel = GetEditPassenger(psngr);
            return View(viewModel);
        }

        public PassengerViewModel GetEditPassenger(Passsenger psngr)
        {
            PassengerViewModel editpsngr = new PassengerViewModel
            {
                PassengerID = psngr.PassengerID,
                PassengerName = psngr.PassengerName,
                PassengerEmail = psngr.PassengerEmail,
                PassengerPhone = psngr.PassengerPhone,
                JourneyDate = psngr.JourneyDate,
                TrainID = psngr.TrainID,
                RouteID = psngr.RouteID,
                ClassID = psngr.ClassID,
                Fee = psngr.Fee,
                ExistingPhotoPath = psngr.PhotoPath
            };
            return editpsngr;
        }

        [HttpPost]
        public IActionResult Edit(PassengerViewModel obj)
        {
            Passsenger psngrObj = _passengerRepository.GetPassengerById(obj.PassengerID);
            if (ModelState.IsValid)
            {
                psngrObj.PassengerName = obj.PassengerName;
                psngrObj.PassengerEmail = obj.PassengerEmail;
                psngrObj.PassengerPhone = obj.PassengerPhone;
                psngrObj.JourneyDate = obj.JourneyDate;
                psngrObj.TrainID = obj.TrainID;
                psngrObj.RouteID = obj.RouteID;
                psngrObj.ClassID = obj.ClassID;
                psngrObj.Fee = obj.Fee;
                if (obj.Photo != null)
                {
                    psngrObj.PhotoPath = ProcessFileUpload(obj);
                    if (obj.ExistingPhotoPath != null)
                    {
                        string filePath = Path.Combine(_hostingEnvironment.WebRootPath, "Images", obj.ExistingPhotoPath);
                        System.IO.File.Delete(filePath);
                    }
                }
                Passsenger psngr = _passengerRepository.UpdatePassenger(psngrObj);
                return RedirectToAction("Index");
            }
            PassengerViewModel viewModel = GetEditPassenger(psngrObj);
            return View(viewModel);
        }

        public IActionResult Delete(int id)
        {
            ViewBag.Trains = _passengerRepository.GetAllTrain();
            ViewBag.Routes = _passengerRepository.GetAllRoute();
            ViewBag.Classes = _passengerRepository.GetAllClass();
            Passsenger pass = _passengerRepository.GetPassengerById(id);
            PassengerViewModel viewModel = GetEditPassenger(pass);
            return View(viewModel);
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteConfirm(int id)
        {
            Passsenger psngrObj = _passengerRepository.GetPassengerById(id);
            if (psngrObj.PhotoPath != null)
            {
                string filePath = Path.Combine(_hostingEnvironment.WebRootPath, "Images", psngrObj.PhotoPath);
                System.IO.File.Delete(filePath);
                Passsenger psngr = _passengerRepository.DeletePassenger(id);
                return RedirectToAction("Index");
            }
            PassengerViewModel viewModel = GetEditPassenger(psngrObj);
            return View(viewModel);
        }

        [AcceptVerbs("Get", "Post")]
        public JsonResult IsEmailInUse(string PassengerEmail)
        {
            bool psngrEmail = _passengerRepository.GetPassengerByEmail(PassengerEmail);
            if (psngrEmail)
            {
                return Json($"Email {PassengerEmail} is already in use");
            }
            else
            {
                return Json(true);
            }
        }

        public IActionResult _Details(int id)
        {
            ViewBag.Trains = _passengerRepository.GetAllTrain();
            ViewBag.Routes = _passengerRepository.GetAllRoute();
            ViewBag.Classes = _passengerRepository.GetAllClass();
            Passsenger psngrObj = _passengerRepository.GetPassengerById(id);
            return View(psngrObj);
        }
    }
}
