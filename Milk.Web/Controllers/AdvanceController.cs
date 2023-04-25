using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Milk.Web.Abstraction;
using Milk.Web.Models;
using Milk.Web.ViewModels;

namespace Milk.Web.Controllers
{
    public class AdvanceController : Controller
    {
        #region Services
        private readonly IAdvanceRepository _advanceRepository;
        private readonly IFarmerRepository _farmerRepository;
        private IUnitOfWork _unitOfWork;

        public AdvanceController(IAdvanceRepository advanceRepository, IFarmerRepository farmerRepository, IUnitOfWork unitOfWork)
        {
            _advanceRepository = advanceRepository;
            _farmerRepository = farmerRepository;
            _unitOfWork = unitOfWork;
        }
        #endregion

        #region Index
        public IActionResult Index()
        {
            AdvanceWrapperViewModel model = new AdvanceWrapperViewModel();
            List<Advance> list = _advanceRepository.GetAllAdvance();
            model.AdvanceList = list.Select(x => new AdvanceListViewModel
            {
                Id = x.Id,
                Name = x.Farmer.Name,
                Amount = x.Amount,
                Date = x.Date.ToString("dd-MM-yyyy"),
            }).ToList();
            return View(model);
        }
        #endregion

        #region Add
        public IActionResult Add()
        {
            var list = _farmerRepository.GetAll();
            List<IdNameViewModel> farmersList = list.Select(x => new IdNameViewModel { Id = x.Id, Name = x.Name }).ToList();
            ViewBag.FarmersList = farmersList.Select(x => new SelectListItem() { Value = x.Id.ToString(), Text = x.Name });
            return View();
        }
        #endregion

        #region Add Advance
        [HttpPost]
        public IActionResult Add(int id, AdvanceViewModel model)
        {
            if (!ModelState.IsValid)
                return View();
            Advance obj = new Advance();
            obj.Amount = model.Amount;
            obj.Date = model.Date;
            obj.FarmerId = model.FarmerId;
            _advanceRepository.Add(obj);
            _unitOfWork.SaveChanges();
            return RedirectToAction("Add", "Advance");
        }
        #endregion

        #region Edit Get Method
        public IActionResult Edit(int id)
        {
            var list = _farmerRepository.GetAll();
            List<IdNameViewModel> farmersList = list.Select(x => new IdNameViewModel { Id = x.Id, Name = x.Name }).ToList();
            ViewBag.FarmersList = farmersList.Select(x => new SelectListItem() { Value = x.Id.ToString(), Text = x.Name });
            var record = _advanceRepository.FindById(id);
            AdvanceEditViewModel model = new AdvanceEditViewModel();
            model.Id = record.Id;
            model.Amount = record.Amount;
            model.Date = record.Date;
            model.FarmerId = record.FarmerId;
            return View(model);
        }
        #endregion

        #region Edit Post method
        [HttpPost]
        public IActionResult Edit(int id, AdvanceEditViewModel model)
        {
            if (!ModelState.IsValid)
                return View();
            var advance = _advanceRepository.FindById(id);
            advance.Amount = model.Amount;
            advance.Date = model.Date;
            advance.FarmerId = model.FarmerId;
            _unitOfWork.SaveChanges();
            return RedirectToAction("details", new { id });
        }
        #endregion

        #region Details
        public IActionResult Details(int id)
        {
            var record = _advanceRepository.FindAdvanceById(id);
            AdvanceDetailsViewModel model = new AdvanceDetailsViewModel();
            model.Id = record.Id;
            model.Amount = record.Amount;
            model.Date = record.Date.ToString("dd-MM-yyyy");
            model.Farmer = record.Farmer.Name;
            return View(model);
        }
        #endregion

        #region Delete
        public IActionResult Delete(int id)
        {
            var record = _advanceRepository.FindById(id);
            if (record != null)
            {
                _advanceRepository.Remove(record);
                _unitOfWork.SaveChanges();
            }
            return RedirectToAction("Index", "Advance");
        }
        #endregion
    }
}