using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Milk.Web.ViewModels
{
    public class ExcelImportModel
    {
        public IFormFile file { get; set; }
        public DateTime EntryDate { get; set; }
    }
}
