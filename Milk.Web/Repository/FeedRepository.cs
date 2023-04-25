using Microsoft.EntityFrameworkCore;
using Milk.Web.Abstraction;
using Milk.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Milk.Web.Repository
{
    public class FeedRepository : Repository<Feed>, IFeedRepository
    {
        public FeedRepository(ApplicationDbContext context) : base(context)
        {
        }

        public List<Feed> GetAllFeed()
        {
            return Set.Include(x => x.Farmer).ToList();
        }

        public Feed FindFeedById(int id)
        {
            return Set.Include(x => x.Farmer).Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
