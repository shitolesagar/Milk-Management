using Milk.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Milk.Web.Abstraction
{
    public interface IFeedRepository : IRepository<Feed>
    {
        List<Feed> GetAllFeed();

        Feed FindFeedById(int id);
    }
}
