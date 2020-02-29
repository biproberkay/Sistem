using Microsoft.EntityFrameworkCore;
using Sistem.Core.Entities;
using Sistem.Infrastructure.Concrete.DataAccess.EfCoreDa.Mappings;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistem.Infrastructure.Concrete.DataAccess.EfCoreDa
{
    public class EfCoreSistemContext : DbContext
    {
        public DbSet<Yer> Yers { get; set; }
        public DbSet<Post> Posts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=SistemDb;Trusted_Connection=True;MultipleActiveResultSets=true");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            YerMapping.Map(modelBuilder.Entity<Yer>());
            PostMapping.Map(modelBuilder.Entity<Post>());
        }
    }
}
