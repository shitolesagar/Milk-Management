using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Milk.Web.ViewModels
{
    public class FarmerAddViewModel
    {
        public string Name { get; set; }
        public string Village { get; set; }
        public string ProfilePicture { get; set; }
        public string MobileNumber { get; set; }
    }

    public class FarmerEditViewModel
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Village { get; set; }
        public string ProfilePicture { get; set; }
        public string MobileNumber { get; set; }
        public bool IsActive { get; set; }
    }

    public class FarmerDetailsViewModel
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Village { get; set; }
        public string ProfilePicture { get; set; }
        public string MobileNumber { get; set; }
        public string IsActive { get; set; }
    }
}
