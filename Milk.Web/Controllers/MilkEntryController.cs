using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Milk.Web.Abstraction;
using Milk.Web.Models;
using Milk.Web.ViewModels;

namespace Milk.Web.Controllers
{
    public class MilkEntryController : Controller
    {
        #region Services
        private readonly IMilkEntryRepository _milkEntryRepository;
        private readonly IFarmerRepository _farmerRepository;
        private readonly IHostingEnvironment _hostingEnvironment;
        private IUnitOfWork _unitOfWork;
        private readonly string[] ACCEPTED_FILE_TYPES = new[] { ".xlsx" };

        public MilkEntryController(IHostingEnvironment env, IMilkEntryRepository milkEntryRepository, IFarmerRepository farmerRepository, IUnitOfWork unitOfWork)
        {
            _hostingEnvironment = env;
            _milkEntryRepository = milkEntryRepository;
            _farmerRepository = farmerRepository;
            _unitOfWork = unitOfWork;
        }
        #endregion

        #region Index
        public IActionResult Index()
        {
            MilkEntryWrapperViewModel model = new MilkEntryWrapperViewModel();
            List<MilkEntry> list = _milkEntryRepository.GetAllEntry();
            model.MilkEntryList = list.Select(x => new MilkEntryListViewModel
            {
                Id = x.Id,
                Name = x.Farmer.Name,
                Milk = x.Milk,
                FAT = x.FAT,
                SNF = x.SNF,
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

        #region Add Entry
        [HttpPost]
        public IActionResult Add(int id, MilkEntryViewModel model)
        {
            if (!ModelState.IsValid)
                return View();
            MilkEntry obj = new MilkEntry();
            obj.Milk = model.Milk;
            obj.FAT = model.FAT;
            obj.SNF = model.SNF;
            obj.Date = model.Date;
            obj.FarmerId = model.FarmerId;
            _milkEntryRepository.Add(obj);
            _unitOfWork.SaveChanges();
            return RedirectToAction("Add", "MilkEntry");
        }
        #endregion

        #region Edit Get Method
        public IActionResult Edit(int id)
        {
            var list = _farmerRepository.GetAll();
            List<IdNameViewModel> farmersList = list.Select(x => new IdNameViewModel { Id = x.Id, Name = x.Name }).ToList();
            ViewBag.FarmersList = farmersList.Select(x => new SelectListItem() { Value = x.Id.ToString(), Text = x.Name });
            var record = _milkEntryRepository.FindById(id);
            MilkEntryEditViewModel model = new MilkEntryEditViewModel();
            model.Id = record.Id;
            model.Milk = record.Milk;
            model.FAT = record.FAT;
            model.SNF = record.SNF;
            model.Date = record.Date;
            model.FarmerId = record.FarmerId;
            return View(model);
        }
        #endregion

        #region Edit Post method
        [HttpPost]
        public IActionResult Edit(int id, MilkEntryEditViewModel model)
        {
            if (!ModelState.IsValid)
                return View();
            var milkentry = _milkEntryRepository.FindById(id);
            milkentry.Milk = model.Milk;
            milkentry.FAT = model.FAT;
            milkentry.SNF = model.SNF;
            milkentry.Date = model.Date;
            milkentry.FarmerId = model.FarmerId;
            _unitOfWork.SaveChanges();
            return RedirectToAction("details", new { id });
        }
        #endregion

        #region Details
        public IActionResult Details(int id)
        {
            var record = _milkEntryRepository.FindEntryById(id);
            MilkEntryDetailsViewModel model = new MilkEntryDetailsViewModel();
            model.Id = record.Id;
            model.Milk = record.Milk;
            model.FAT = record.FAT;
            model.SNF = record.SNF;
            model.Date = record.Date.ToString("dd-MM-yyyy");
            model.Farmer = record.Farmer.Name;
            return View(model);
        }
        #endregion

        #region Delete
        public IActionResult Delete(int id)
        {
            var record = _milkEntryRepository.FindById(id);
            if (record != null)
            {
                _milkEntryRepository.Remove(record);
                _unitOfWork.SaveChanges();
            }
            return RedirectToAction("Index", "MilkEntry");
        }
        #endregion

        #region MilkEntryExcelImport
        public IActionResult MilkEntryExcelImport()
        {
            return View();
        }
        #endregion

        #region MilkEntryExcelImport
        [HttpPost]
        public async Task<IActionResult> MilkEntryExcelImport(IFormFile file, DateTime EntryDate)
        {
            List<MilkEntry> List = new List<MilkEntry>();
            try
            {
                ImportedFile importedFile = new ImportedFile();
                if (file == null) return BadRequest("File not found.");
                if (file.Length == 0) return BadRequest("Empty file");
                //  if (file.Length > MAX_BYTE) return BadRequest("File exciding 2 MB");
                if (!ACCEPTED_FILE_TYPES.Any(s => s == Path.GetExtension(file.FileName))) return BadRequest("Invalide file type");

                string uploadFolderPath = Path.Combine(_hostingEnvironment.WebRootPath, "excelimport");
                if (!System.IO.Directory.Exists(uploadFolderPath))
                    System.IO.Directory.CreateDirectory(uploadFolderPath);

                var filename = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                var filepath = Path.Combine(uploadFolderPath, filename);

                importedFile.Date = EntryDate;

                using (var stream = new FileStream(filepath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
                // ReadExcel is private method which used to ready file 
                List = ReadExcel(filepath, EntryDate);
                _milkEntryRepository.AddRange(List);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception e)
            {

            }
            return RedirectToAction("MilkEntryExcelImport", "MilkEntry");
        }
        #endregion

        #region Private Methods
        private List<MilkEntry> ReadExcel(string filepath, DateTime EntryDate)
        {
            List<MilkEntry> List = new List<MilkEntry>();
            try
            {
                XLWorkbook xLWorkbook = new XLWorkbook(filepath);
                IXLWorksheet workSheet = xLWorkbook.Worksheet(1);
                bool firstRow = true;
                foreach (IXLRow row in workSheet.Rows())
                {
                    MilkEntry obj = new MilkEntry();
                    //Use the first row to add columns to DataTable.
                    if (firstRow)
                    {
                        firstRow = false;
                        continue;
                    }

                    if(row.Cell(1).IsEmpty())
                    {
                        return List;
                    }

                    obj.FarmerId = row.Cell(1).GetValue<int>();
                    obj.Milk = row.Cell(4).GetValue<float>();
                    obj.FAT = row.Cell(5).GetValue<float>();
                    obj.SNF = row.Cell(6).GetValue<float>();
                    obj.Date = EntryDate;
                    List.Add(obj);
                }
            }
            catch (Exception e)
            {
            }
            return List;
        }
        #endregion
    }
}