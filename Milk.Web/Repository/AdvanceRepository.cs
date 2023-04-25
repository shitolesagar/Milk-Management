using Microsoft.EntityFrameworkCore;
using Milk.Web.Abstraction;
using Milk.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Milk.Web.Repository
{
    public class AdvanceRepository : Repository<Advance>, IAdvanceRepository
    {
        public AdvanceRepository(ApplicationDbContext context) : base(context)
        {
        }

        public List<Advance> GetAllAdvance()
        {
            return Set.Include(x => x.Farmer).ToList();
        }

        public Advance FindAdvanceById(int id)
        {
            return Set.Include(x => x.Farmer).Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
