using Microsoft.EntityFrameworkCore;
using Milk.Web.Abstraction;
using Milk.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Milk.Web.Repository
{
    public class MilkEntryRepository : Repository<MilkEntry>, IMilkEntryRepository
    {
        public MilkEntryRepository(ApplicationDbContext context) : base(context)
        {
        }

        public List<MilkEntry> GetAllEntry ()
        {
            return Set.Include(x => x.Farmer).ToList();
        }

        public MilkEntry FindEntryById (int id)
        {
            return Set.Include(x => x.Farmer).Where(x => x.Id == id).FirstOrDefault();
        }

        public void AddRange(IEnumerable<MilkEntry> list)
        {
            Set.AddRange(list);
        }
    }
}
