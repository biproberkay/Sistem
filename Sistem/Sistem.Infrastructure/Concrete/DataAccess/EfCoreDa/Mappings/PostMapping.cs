using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sistem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistem.Infrastructure.Concrete.DataAccess.EfCoreDa.Mappings
{
    internal class PostMapping 
    {
        internal static void Map(EntityTypeBuilder<Post> builder)
        {
            builder.Property(a => a.Title).IsRequired();
            builder.Property(a => a.Summary).IsRequired();
            builder.Property(a => a.Body).IsRequired();
            builder.Property(a => a.DateCreated).IsRequired();

            //builder.HasMany(a=>a.)
        }
    }
}
