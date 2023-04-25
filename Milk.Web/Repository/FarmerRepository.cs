using Milk.Web.Abstraction;
using Milk.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Milk.Web.Repository
{
    public class FarmerRepository : Repository<Farmer>, IFarmerRepository
    {
        public FarmerRepository(ApplicationDbContext context) : base(context)
        {
        }

    }
}
