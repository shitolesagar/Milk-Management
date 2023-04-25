using Microsoft.EntityFrameworkCore;
using Milk.Web.Configurations;
using Milk.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Milk.Web
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Advance> Advance { get; set; }
        public DbSet<Farmer> Farmer { get; set; }
        public DbSet<Feed> Feed { get; set; }
        public DbSet<MilkEntry> MilkEntry { get; set; }
        public DbSet<RateChart> RateChart { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ApplicationUserConfiguration());
            modelBuilder.ApplyConfiguration(new AdvanceConfiguration());
            modelBuilder.ApplyConfiguration(new FarmerConfiguration());
            modelBuilder.ApplyConfiguration(new FeedConfiguration());
            modelBuilder.ApplyConfiguration(new MilkEntryConfiguration());
            modelBuilder.ApplyConfiguration(new RateChartConfiguration());
        }
    }
}
