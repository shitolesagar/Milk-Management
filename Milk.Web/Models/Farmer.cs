using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Milk.Web.Models
{
    public class Farmer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Village { get; set; }
        public string ProfilePicture { get; set; }
        public string MobileNumber { get; set; }
        public bool IsActive { get; set; }

        public ICollection<Advance> Advances { get; set; }
        public ICollection<MilkEntry> MilkEntries { get; set; }
        public ICollection<Feed> Feeds { get; set; }
    }
}
