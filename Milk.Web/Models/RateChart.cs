using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Milk.Web.Models
{
    public class RateChart
    {
        public int Id { get; set; }
        public float FAT { get; set; }
        public float SNF { get; set; }
        public float Rate { get; set; }
    }
}
