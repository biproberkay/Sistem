using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sistem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistem.Infrastructure.Concrete.DataAccess.EfCoreDa.Mappings
{
    internal class YerMapping
    {
        internal static void Map(EntityTypeBuilder<Yer> builder)
        {
            builder.Property(a => a.Title).IsRequired();

            builder.HasMany(a => a.Posts)
                    .WithOne(a => a.Yer)
                    .HasForeignKey(a => a.YerId)
                    .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
