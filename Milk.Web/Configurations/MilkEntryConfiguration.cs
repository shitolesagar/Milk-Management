using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Milk.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Milk.Web.Configurations
{
    internal class MilkEntryConfiguration : IEntityTypeConfiguration<MilkEntry>
    {
        public void Configure(EntityTypeBuilder<MilkEntry> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseMySqlIdentityColumn();

            builder.HasOne(x => x.Farmer).WithMany(x => x.MilkEntries).HasForeignKey(x => x.FarmerId);
        }
    }
}
