using Milk.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Milk.Web.Abstraction
{
    public interface IMilkEntryRepository : IRepository<MilkEntry>
    {
        List<MilkEntry> GetAllEntry();

        MilkEntry FindEntryById(int id);

        void AddRange(IEnumerable<MilkEntry> list);
    }
}
