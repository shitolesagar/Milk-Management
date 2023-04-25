using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Milk.Web.ViewModels
{
    public class AdvanceViewModel
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; }

        public int FarmerId { get; set; }
    }

    public class AdvanceWrapperViewModel
    {
        public List<AdvanceListViewModel> AdvanceList { get; set; }
    }

    public class AdvanceListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public string Date { get; set; }
    }

    public class AdvanceEditViewModel
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; }

        public int FarmerId { get; set; }
    }

    public class AdvanceDetailsViewModel
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public string Date { get; set; }
        public string Farmer { get; set; }
    }
}
