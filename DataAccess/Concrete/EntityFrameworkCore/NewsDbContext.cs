using DataAccess.Concrete.EntityFrameworkCore.Mappings;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFrameworkCore
{
    public class NewsDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-ES3PPQC;Database=NewsMngSystem;integrated security=true;Connection Timeout=1800;MultipleActiveResultSets=True");
        }

        public DbSet<News> Newss { get; set; }
        public DbSet<Category> Categories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<News>(new NewsMap());
            modelBuilder.ApplyConfiguration<Category>(new CategoryMap());
        }
    }
}
