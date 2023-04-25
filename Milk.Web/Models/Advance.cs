using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Milk.Web.Models
{
    public class Advance
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; }

        public int FarmerId { get; set; }
        public Farmer Farmer { get; set; }
    }
}
