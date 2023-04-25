using Milk.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Milk.Web.Abstraction
{
    public interface IAdvanceRepository : IRepository<Advance>
    {
        List<Advance> GetAllAdvance();

        Advance FindAdvanceById(int id);
    }
}
