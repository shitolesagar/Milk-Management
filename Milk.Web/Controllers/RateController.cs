using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Milk.Web.Abstraction;
using Milk.Web.Models;
using Milk.Web.ViewModels;

namespace Milk.Web.Controllers
{
    public class RateController : Controller
    {
        #region Services
        private readonly IMilkEntryRepository _milkEntryRepository;
        private readonly IFarmerRepository _farmerRepository;
        private readonly IRateChartRepository _rateChartRepository;
        private readonly IHostingEnvironment _hostingEnvironment;
        private IUnitOfWork _unitOfWork;
        private readonly string[] ACCEPTED_FILE_TYPES = new[] { ".xlsx" };

        public RateController(IHostingEnvironment env, IRateChartRepository rateChartRepository, IMilkEntryRepository milkEntryRepository, IFarmerRepository farmerRepository, IUnitOfWork unitOfWork)
        {
            _hostingEnvironment = env;
            _milkEntryRepository = milkEntryRepository;
            _farmerRepository = farmerRepository;
            _rateChartRepository = rateChartRepository;
            _unitOfWork = unitOfWork;
        }
        #endregion

        #region Index
        public IActionResult Index()
        {
            RateChartWrapperViewModel model = new RateChartWrapperViewModel();
            List<RateChart> list = _rateChartRepository.GetAll();
            model.RateChartList = list.Select(x => new RateChartListViewModel
            {
                Id = x.Id,
                FAT = x.FAT,
                SNF = x.SNF,
                Rate = x.Rate,
            }).ToList();
            return View(model);
        }
        #endregion

        #region RateSheetImport
        public IActionResult RateSheetImport()
        {
            return View();
        }
        #endregion

        #region RateSheetImport
        [HttpPost]
        public async Task<IActionResult> RateSheetImport (IFormFile file)
        {
            List<RateChart> List = new List<RateChart>();
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

                using (var stream = new FileStream(filepath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
                // ReadExcel is private method which used to ready file 
                List = ReadExcel(filepath);
                _rateChartRepository.AddRange(List);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception e)
            {

            }
            return RedirectToAction("RateSheetImport", "Rate");
        }
        #endregion

        #region EditRateGet
        public IActionResult EditRate()
        {
            return View();
        }
        #endregion

        #region EditRatePost
        [HttpPost]
        public IActionResult EditRate()
        {
            List<RateChart> list = _rateChartRepository.GetAll();
            return View();
        }
        #endregion

        #region Private Methods
        private List<RateChart> ReadExcel(string filepath)
        {
            List<RateChart> List = new List<RateChart>();
            try
            {
                XLWorkbook xLWorkbook = new XLWorkbook(filepath);
                IXLWorksheet workSheet = xLWorkbook.Worksheet(1);
                bool firstRow = true;
                foreach (IXLRow row in workSheet.Rows())
                {
                    RateChart obj = new RateChart();
                    //Use the first row to add columns to DataTable.
                    if (firstRow)
                    {
                        firstRow = false;
                        continue;
                    }

                    if (row.Cell(1).IsEmpty())
                    {
                        return List;
                    }

                    obj.FAT = row.Cell(1).GetValue<float>();
                    obj.SNF = row.Cell(2).GetValue<float>();
                    obj.Rate = row.Cell(3).GetValue<float>();
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

    public enum IncDec
    {
        Increment,
        Decrement
    }
}