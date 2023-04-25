using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Milk.Web.Models
{
    public class MilkEntry
    {
        public int Id { get; set; }
        public float Milk { get; set; }
        public float FAT { get; set; }
        public float SNF { get; set; }
        public DateTime Date { get; set; }

        public int FarmerId { get; set; }
        public Farmer Farmer { get; set; }
    }
}
