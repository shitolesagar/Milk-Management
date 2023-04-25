using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Milk.Web.Abstraction;
using Milk.Web.Models;
using Milk.Web.ViewModels;

namespace Milk.Web.Controllers
{
    public class FarmerController : Controller
    {
        #region Services
        private readonly IFarmerRepository _farmerRepository;
        private IUnitOfWork _unitOfWork;

        public FarmerController(IFarmerRepository farmerRepository, IUnitOfWork unitOfWork)
        {
            _farmerRepository = farmerRepository;
            _unitOfWork = unitOfWork;
        }
        #endregion

        #region Index
        public IActionResult Index()
        {
            FarmerWrapperViewModel model = new FarmerWrapperViewModel();
            List<Farmer> list = _farmerRepository.GetAll();
            model.FarmerList = list.Select(x => new FarmerListViewModel
            {
                Id = x.Id,
                Name = x.Name,
            }).ToList();
            return View(model);
        }
        #endregion

        #region Add Get Method
        public IActionResult Add()
        {
            return View();
        }
        #endregion

        #region Add Post Method
        [HttpPost]
        public IActionResult Add(FarmerAddViewModel model)
        {
            if (!ModelState.IsValid)
                return View();
            Farmer obj = new Farmer()
            {
                Name = model.Name,
                Village = model.Village,
                ProfilePicture = model.ProfilePicture,
                MobileNumber = model.ProfilePicture,
                IsActive = true,
            };
            _farmerRepository.Add(obj);
            _unitOfWork.SaveChanges();
            return RedirectToAction("index", "farmer");
        }
        #endregion

        #region Edit Get Method
        public IActionResult Edit(int id)
        {
            var record = _farmerRepository.FindById(id);
            FarmerEditViewModel model = new FarmerEditViewModel();
            model.id = record.Id;
            model.Name = record.Name;
            model.Village = record.Village;
            model.ProfilePicture = record.ProfilePicture;
            model.MobileNumber = record.MobileNumber;
            model.IsActive = record.IsActive;
            return View(model);
        }
        #endregion

        #region Edit Post method
        [HttpPost]
        public IActionResult Edit(int id, FarmerEditViewModel model)
        {
            if (!ModelState.IsValid)
                return View();
            var farmer = _farmerRepository.FindById(id);
            farmer.Name = model.Name;
            farmer.Village = model.Village;
            farmer.ProfilePicture = model.ProfilePicture;
            farmer.MobileNumber = model.MobileNumber;
            farmer.IsActive = model.IsActive;
            _unitOfWork.SaveChanges();
            return RedirectToAction("details", new { id });
        }
        #endregion

        #region Details
        public IActionResult Details(int id)
        {
            var record = _farmerRepository.FindById(id);
            FarmerDetailsViewModel model = new FarmerDetailsViewModel();
            model.id = record.Id;
            model.Name = record.Name;
            model.Village = record.Village;
            model.ProfilePicture = record.ProfilePicture;
            model.MobileNumber = record.MobileNumber;
            model.IsActive = record.IsActive ? "Active" : "InActive";
            return View(model);
        }
        #endregion

        #region Delete
        public IActionResult Delete(int id)
        {
            var record = _farmerRepository.FindById(id);
            if(record != null)
            {
                _farmerRepository.Remove(record);
                _unitOfWork.SaveChanges();
            }
            return RedirectToAction("Index", "Farmer");
        }
        #endregion
    }
}