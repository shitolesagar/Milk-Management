using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Milk.Web.ViewModels
{
    public class FeedViewModel
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; }

        public int FarmerId { get; set; }
    }

    public class FeedWrapperViewModel
    {
        public List<FeedListViewModel> FeedList { get; set; }
    }

    public class FeedListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public string Date { get; set; }
    }

    public class FeedEditViewModel
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; }

        public int FarmerId { get; set; }
    }

    public class FeedDetailsViewModel
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public string Date { get; set; }
        public string Farmer { get; set; }
    }
}
