using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Milk.Web.ViewModels
{
    public class RateChartWrapperViewModel
    {
        public List<RateChartListViewModel> RateChartList { get; set; }
    }

    public class RateChartListViewModel
    {
        public int Id { get; set; }
        public float FAT { get; set; }
        public float SNF { get; set; }
        public float Rate { get; set; }
    }
}
