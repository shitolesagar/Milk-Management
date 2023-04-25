using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Milk.Web.ViewModels
{
    public class MilkEntryViewModel
    {
        public float Milk { get; set; }
        public float FAT { get; set; }
        public float SNF { get; set; }
        public DateTime Date { get; set; }

        public int FarmerId { get; set; }
    }

    public class MilkEntryWrapperViewModel
    {
        public List<MilkEntryListViewModel> MilkEntryList { get; set; }
    }

    public class MilkEntryListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Milk  { get; set; }
        public float FAT { get; set; }
        public float SNF { get; set; }
        public string Date { get; set; }
    }

    public class MilkEntryEditViewModel
    {
        public int Id { get; set; }
        public float Milk { get; set; }
        public float FAT { get; set; }
        public float SNF { get; set; }
        public DateTime Date { get; set; }

        public int FarmerId { get; set; }
    }

    public class MilkEntryDetailsViewModel
    {
        public int Id { get; set; }
        public float Milk { get; set; }
        public float FAT { get; set; }
        public float SNF { get; set; }
        public string Date { get; set; }

        public string Farmer { get; set; }
    }
}
