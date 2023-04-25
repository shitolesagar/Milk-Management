using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Milk.Web.ViewModels
{
    public class FarmerWrapperViewModel
    {
        public List<FarmerListViewModel> FarmerList { get; set; }
    }

    public class FarmerListViewModel 
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
