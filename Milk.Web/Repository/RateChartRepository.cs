using Milk.Web.Abstraction;
using Milk.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Milk.Web.Repository
{
    public class RateChartRepository : Repository<RateChart>, IRateChartRepository
    {
        public RateChartRepository(ApplicationDbContext context) : base(context)
        {
        }

        public void AddRange(IEnumerable<RateChart> list)
        {
            Set.AddRange(list);
        }
    }
}
